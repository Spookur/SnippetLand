using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using InsertingFiles.Models;
using Dapper;

namespace InsertingFiles.Controllers
{
    public class SoundController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<SoundModel>("GetAllSoundsp"));
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string fileName = Path.GetFileName(file.FileName);
                string fileExt = Path.GetExtension(fileName);
                if (fileExt == ".wav" || fileExt == ".mp3")
                {
                    string filePath = Path.Combine(Server.MapPath("~/sound"), fileName);
                    string mainConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainConn);
                    SqlCommand sqlcomm = new SqlCommand("Insertsoundsp", sqlconn);
                    sqlcomm.CommandType = CommandType.StoredProcedure;
                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@soundName", fileName);
                    sqlcomm.Parameters.AddWithValue("@soundExt", fileExt);
                    sqlcomm.Parameters.AddWithValue("@soundPath", filePath);
                    sqlcomm.ExecuteNonQuery();
                    file.SaveAs(filePath);
                    sqlconn.Close();
                }
            }
            return RedirectToAction("Index");
        }
    }
}