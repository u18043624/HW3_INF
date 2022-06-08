using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using u18043624_HW03.Models;

namespace u18043624_HW03.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Home()
		{
			var items = GetFiles();
			return View(items);
		}

		[HttpPost]
		public ActionResult Home(HttpPostedFileBase File)
		{
			if (File != null && File.ContentLength > 0)
			{
				try
				{
					var fileName = Path.GetFileName(File.FileName);
					var path = Path.Combine(Server.MapPath("~/App_Data/Documents"), fileName);
					File.SaveAs(path);
					ViewBag.Message = "File uploaded";
				}
				catch (Exception ex)
				{
					ViewBag.Message = "Error" + ex.Message.ToString();
				}

			}
			else
			{
				ViewBag.Message = "You have not specified a file";
			}
			
			return RedirectToAction("Home");
		}
		/*
		private List<string> GetFiles()
		{
			var path = new DirectoryInfo(Server.MapPath("~/App_Data/Documents"));
			FileInfo[] filenames = path.GetFiles("*.*");

			List<string> items = new List<string>();
			foreach(var file in filenames)
			{
				items.Add(file.Name);
			}
			return items;
		}
		*/
		/*
		public FileResult Download(string ImageName)
		{
			var FileVPath = "~/App_Data/Documents" + ImageName;
			return File(FileVPath, "application/force- download", Path.GetFileName(FileVPath));
		}
		*/
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Files()
		{
			string[] filePaths = Directory.GetFiles(Server.MapPath("~/App_Data/Documents"));

			List<FileModelcs> files = new List<FileModelcs>();

			foreach (string filePath in filePaths)
			{
				files.Add(new FileModelcs { FileName = Path.GetFileName(filePath) });
			}
			
			ViewBag.Message = "";

			return View(files);
		}
		public ActionResult Images()
		{
			ViewBag.Message = "";

			return View();
		}
		public ActionResult Videos()
		{
			ViewBag.Message = "";

			return View();
		}


	}
}