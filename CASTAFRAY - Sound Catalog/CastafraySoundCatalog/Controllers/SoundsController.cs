using CastafraySoundCatalog.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CastafraySoundCatalog.Controllers
{
    public class SoundsController : Controller
    {
        // GET: Sounds
        public ActionResult SoundManager()
        {
            return View(DapperORM.ReturnList<SoundModel>("GetAllSoundsp"));
        }

        [HttpGet]
        public ActionResult SoundManagerAddOrEdit(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SoundId", id);
                return View(DapperORM.ReturnList<SoundModel>("SoundViewById", param).FirstOrDefault<SoundModel>());
            }


        }

        [HttpPost]
        public ActionResult SoundManagerAddOrEdit(SoundModel soundModel)
        {
            

            DynamicParameters param = new DynamicParameters();
            param.Add("@SoundId", soundModel.SoundId);
            param.Add("@Title", soundModel.Title);
            param.Add("@Artist", soundModel.Artist);
            param.Add("@Description", soundModel.Description);
            param.Add("@FilePath", soundModel.FilePath);
            param.Add("@FileSize", soundModel.FileSize);
            DapperORM.ExecuteWithoutReturn("SoundAddOrEdit", param);

            return RedirectToAction("SoundManager");
        }


        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SoundId", id);
            DapperORM.ExecuteWithoutReturn("SoundDeleteById", param);
            return RedirectToAction("SoundManager");
        }



        [HttpPost]
        public ActionResult SoundAdd(HttpPostedFileBase file)
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
            return RedirectToAction("SoundAdd");
        }

        public ActionResult SoundAdd()
        {
            return View();
        }
    }
}
