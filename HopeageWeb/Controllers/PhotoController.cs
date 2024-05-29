using HopeageWeb.Data;
using HopeageWeb.Models;
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
            List<Photo> objPhotoList = _db.Photos.ToList();
            return View(objPhotoList);
        }
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(Photo obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.Photos.Add(obj);
                
                _db.SaveChanges();
                TempData["success"] = "Officer Created Successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Photo? photoFromDb = _db.Photos.Find(id);

            if (photoFromDb == null)
            {
                return NotFound();
            }

            return View(photoFromDb);

        }
        [HttpPost]
        public IActionResult Edit(Photo obj)
        {
            if (ModelState.IsValid)
            {
                
                _db.Photos.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Officer Update Successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Photo? photoFromDb = _db.Photos.Find(id);

            if (photoFromDb == null)
            {
                return NotFound();
            }

            return View(photoFromDb);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Photo? obj = _db.Photos.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Photos.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Officer Update Successfully";
            return RedirectToAction("Index");

        }
    }
}
