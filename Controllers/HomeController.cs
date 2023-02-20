using Microsoft.AspNetCore.Mvc;

namespace Projeto_Sistema_WEB.Controllers

{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "";
            ViewData["email"] = "";

            return View();
        }

        public IActionResult Contact()
        {

        }

        public IActionResult Privacy()
        {
            
        }




    }
}