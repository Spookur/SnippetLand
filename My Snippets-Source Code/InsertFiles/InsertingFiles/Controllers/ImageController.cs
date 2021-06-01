using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace InsertingFiles.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if(file != null && file.ContentLength > 0)
            {
                string fileName = Path.GetFileName(file.FileName);
                string fileExt = Path.GetExtension(fileName);
                if(fileExt ==".jpg" || fileExt == ".png")
                {
                    string filePath = Path.Combine(Server.MapPath("~/image"), fileName);
                    string mainConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainConn);
                    SqlCommand sqlcomm = new SqlCommand("Insertimgsp", sqlconn);
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@imgName", fileName);
                    sqlcomm.Parameters.AddWithValue("@imgExt", fileExt);
                    sqlcomm.Parameters.AddWithValue("@imgPath", filePath);
                    sqlcomm.ExecuteNonQuery();
                    file.SaveAs(filePath);
                    sqlconn.Close();
                }
            }
            return RedirectToAction("Index");
        }
    }
}