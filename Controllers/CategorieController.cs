using Microsoft.AspNetCore.Mvc;

namespace live.Controllers
{
    public class CategorieController : Controller
    {
        [Route("api/[controller]")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
