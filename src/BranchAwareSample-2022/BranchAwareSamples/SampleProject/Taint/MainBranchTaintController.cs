using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Taint
{
    //Taint should be visible in main
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
