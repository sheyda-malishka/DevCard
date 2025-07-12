using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project> 
            { 
                new Project(id:1 , name:"تاکسی " , description:"درخواست انلاین تاکسی",image:"project-1.jpg" , client:"Atriya"),
                new Project(id:2 , name:"زودفود" , description:"درخواست انلاین غذا ", image:"project-2.jpg",client:"ZoodFood"),
                new Project(id:3 , name:"مدارس  " , description:"سیستم یکپارجه مدارس" ,image:"project-3.jpg", client:"MONOP"),
                new Project(id:4 , name:"فضاپیما " , description:"برنامه مدیریت فضاپیماهای ناسا",image:"project-4.jpg" , client:"NASA"),
            };
            
            

            return View("_Projects" , projects);
        }

    }
}
