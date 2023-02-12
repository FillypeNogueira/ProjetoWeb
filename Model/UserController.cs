using Microsoft.AspNetCore.Mvc;

namespace Projeto_Sistema_WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]

        public string Get()
        {
            return "ok";
        }
        
    }
}