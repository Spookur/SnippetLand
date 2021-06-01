using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadAudio.Models;

namespace UploadAudio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UploadAudio()
        {
            List<AudioFile> audiolist = new List<AudioFile>();
            string CS = ConfigurationManager.ConnectionStrings["Prod"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spGetAllAudioFile", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    AudioFile audio = new AudioFile();
                    audio.ID = Convert.ToInt32(rdr["ID"]);
                    audio.Name = rdr["Name"].ToString();
                    audio.FileSize = Convert.ToInt32(rdr["FileSize"]);
                    audio.FilePath = rdr["FilePath"].ToString();

                    audiolist.Add(audio);
                }
            }
            return View(audiolist);
        }
        [HttpPost]
        public ActionResult UploadAudio(HttpPostedFileBase fileupload)
        {
            if (fileupload != null)
            {
                string fileName = Path.GetFileName(fileupload.FileName);
                int fileSize = fileupload.ContentLength;
                int Size = fileSize / 1000000;
                fileupload.SaveAs(Server.MapPath("~/AudioFileUpload/" + fileName));

                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spAddNewAudioFile", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Name", fileName);
                    cmd.Parameters.AddWithValue("@FileSize", Size);
                    cmd.Parameters.AddWithValue("FilePath", "~/AudioFileUpload/" + fileName);
                    cmd.ExecuteNonQuery();
                }
            }
            return RedirectToAction("UploadAudio");
        }
    }
}  
