using Microsoft.AspNetCore.Mvc;

namespace minimalAPIMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
