using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projeto_Sistema_WEB.Views.Home.Departamentos
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;

        public Index(ILogger<Index> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}