using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u18043624_HW03.Models
{
	public class FileModelcs
	{
		public string FileName { get; set; }

		public HttpPostedFileBase Files { get; set; }
	}
}