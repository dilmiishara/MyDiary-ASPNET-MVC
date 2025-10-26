using Microsoft.AspNetCore.Mvc;

namespace MyDiary.Controllers
{
    public class DiaryEntriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
