using Microsoft.AspNetCore.Mvc;

namespace live.Controllers
{
    public class CategorieController : Controller
    {
        [ApiController]
        [Route("api/[controller]")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
