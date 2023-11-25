using Microsoft.AspNetCore.Mvc;

namespace ConsumeSchoolMgtService.Controllers
{
    public class ConsumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
