using Microsoft.AspNetCore.Mvc;
using Projeto_Sistema_WEB.Model;

namespace Projeto_Sistema_WEB.Controllers
{
    [Route("[controller]")]
    public class DepartamentosController : Controller
    {
        private readonly ILogger<DepartamentosController> _logger;

        public DepartamentosController(ILogger<DepartamentosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento {Id = 1, Name = "Eletronics"});
            list.Add(new Departamento {Id = 2, Name = "Fashion"});
            
            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}