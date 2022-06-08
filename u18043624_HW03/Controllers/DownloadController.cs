using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using u18043624_HW03.Models;

namespace u18043624_HW03.Controllers
{
    public class DownloadController : Controller
    {
        // GET: Download
        public ActionResult Download()
        {
            string[] filePaths =  Directory.GetFiles(Server.MapPath("~/App_Data/Documents"));

            List<FileModelcs> files = new List<FileModelcs>();

            foreach(string filePath in filePaths)
            {
                files.Add(new FileModelcs{FileName = Path.GetFileName(filePath)});
            }
            return View(files);
        }
    }
}