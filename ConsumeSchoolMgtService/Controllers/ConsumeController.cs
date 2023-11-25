using Microsoft.AspNetCore.Mvc;

namespace ConsumeSchoolMgtService.Controllers
{
    public class ConsumeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
