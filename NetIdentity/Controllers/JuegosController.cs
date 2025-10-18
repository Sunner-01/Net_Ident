using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NetIdentity.Controllers
{
  
    public class JuegosController : Controller
    {
        [Authorize(Policy = "SoloMasculino")]
        // [Authorize(Policy = "menoresEdad")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Usuario")]
        public IActionResult JuegoEducativo()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Aventuras()
        {
            return View();
        }
    }

}
