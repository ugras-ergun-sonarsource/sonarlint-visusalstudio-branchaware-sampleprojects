using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SampleProject.Taint
{
    public class MainBranchTaintController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // Simple taint issue - just involves this method
        public ActionResult DeleteFile(string fileName)
        {
            System.IO.File.Delete(fileName); // Noncompliant

            return Content("File " + fileName + " deleted");
        }
    }
}
