using HopeageWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace HopeageWeb.Controllers
{
    public class PhotoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PhotoController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
