using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using u18043624_HW03.Models;

namespace u18043624_HW03.Models
{
	public class FileModelcs
	{
		public string FileName { get; set; }

		public HttpPostedFileBase File { get; set; }
	}
}