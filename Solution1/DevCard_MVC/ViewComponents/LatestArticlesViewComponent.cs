using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article> 
            { 
                new Article(id:1 , title:"آموزش asp.net core mvc" , description:"کامل ترین پکیج آموزش asp.net core mvc" , image:"blog-post-thumb-card-1.jpg"),
                new Article(id:2 , title:"آموزش Git & Github" , description:"کامل ترین پکیج آموزش Git & Github" , image:"blog-post-thumb-card-2.jpg"),
                new Article(id:3 , title:"آموزش Onion Architecture" , description:"کامل ترین پکیج آموزش Onion Architecture" , image:"blog-post-thumb-card-3.jpg"),
                new Article(id:4 , title:"آموزش Front-end" , description:"کامل ترین پکیج آموزش Front-end" , image:"blog-post-thumb-card-4.jpg"),
            };

            return View("_LatestArticles" , articles);
        }   
    }
}
