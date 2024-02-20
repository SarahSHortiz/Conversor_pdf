using Microsoft.AspNetCore.Mvc;

namespace ConversorDePDF.Controllers
{
    public class Leitor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
