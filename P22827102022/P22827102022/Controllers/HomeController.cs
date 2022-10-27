using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22827102022.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            //ViewBag.Name = "Hamid";
            //ViewData["SurName"] = "Mammadov";

            //int a = 5;

            //TempData["Age"] = 32;

            //return RedirectToAction("second");

            List<string> stulist = new List<string>
            {
                "Shahnigar","Irade","Sema","Nicat","Shefa","Medine","Terlan"
            };

            ViewBag.Students = stulist;

            return View();
        }

        public IActionResult Second()
        {
            return View();
        }
        //public ViewResult Second()
        //{
        //    return View();
        //}

        //public IActionResult Index(int? id)
        //{
        //    ViewResult viewResult = new ViewResult();
        //    viewResult.ViewName = "firstview";
        //    ContentResult contentResult = new ContentResult();
        //    contentResult.Content = "P228 Content";
        //    if (id == 1)
        //    {
        //        return viewResult;
        //    }
        //    else
        //    {
        //        return contentResult;
        //    }
        //}

        //public JsonResult Index()
        //{
        //    return Json(new { name = "Test", surname = "Testov" });
        //}

        //public ContentResult Index()
        //{
        //    return Content("First Content");
        //}

        //public ViewResult Index()
        //{
        //    ViewResult viewResult = new ViewResult();
        //    viewResult.ViewName = "firstview";
        //    return viewResult;
        //}

        //public JsonResult Index() 
        //{

        //    return new JsonResult(new { name="Hamid",surname="Mammadov"});
        //}

        //public ContentResult Index()
        //{


        //    return new ContentResult { Content = "TEst",ContentType="application",StatusCode=666};
        //}
    }
}
