using System.Diagnostics;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Service> _services = new List<Service>
        {
            new Service(1 , "نقره ای "),
            new Service(2 , "طلایی "),
            new Service(3 , "پلاتین"),
            new Service(4 , "الماسی "),
        };


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_services, dataValueField: "Id", dataTextField: "Name")
            };
            return View(model);
        }


        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());

        //}


        //Form Validation-Client 
        //[HttpPost]
        //public JsonResult Contact(Contact form) 
        //{
        //    Console.WriteLine(form.ToString());
        //    return Json(Ok());
        //}


        //Form Validation-Server
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            

            model.Services = new SelectList(_services, dataValueField: "Id", dataTextField: "Name");
            

            if (!ModelState.IsValid)
            {
               
                ViewBag.error="اطلاعات وارد شده صحیح نمی باشد لطفا دوباره تلاش کنید";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(_services, dataValueField: "Id", dataTextField: "Name")
            };

            ViewBag.success= "پیغام شما با موفقیت ارسال شد . باتشکر";
            return View(model);

        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

