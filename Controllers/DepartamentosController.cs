using Microsoft.AspNetCore.Mvc;
using Projeto_Sistema_WEB.Model;

namespace Projeto_Sistema_WEB.Controllers
{
    [Route("api/[controller]")]
    public class DepartamentosController : Controller
    {

        private static List<Departamento> Departamentos()
        {
            return new List<Departamento>
            {
               
            };
        }
    }
}