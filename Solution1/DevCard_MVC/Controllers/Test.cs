using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class Test : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public IActionResult Index()
        //{
        //    return View("Footer");
        //}

        //public ContentResult Index()
        //{
        //    return Content("<h1> Hello Student </h1>" , contentType:"text/html");
        //}

        //public EmptyResult Index()
        //{
        //    //return new EmptyResult();
        //    return null;
        //}

        public JsonResult Index() 
        {
            return Json(new
            {
                id = 1,
                name="Amin",
                job="student",
                
            });
        }




    }
}
