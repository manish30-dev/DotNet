using BulkyBookRepo.Model;
using BulkyBookService;

using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServ _categoryServ;

        public CategoryController( ICategoryServ categoryServ)
        {
            
            _categoryServ = categoryServ;
        }
        public IActionResult Index()
        {
            var objCategory = _categoryServ.Getall();
            return View(objCategory);
        }
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _categoryServ.Create(obj);
                TempData["success"] = "Category created Succesfully !";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Update(int id)
        {
            if(id == null || id==0)
            {
                return NotFound();
            }
            Category catgObj = _categoryServ.Find(id);
            
            return View(catgObj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Category obj)
        {
            if (ModelState.IsValid)
            {
                
                _categoryServ.Update(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int id)
        {
            _categoryServ.Delete(id);
            return RedirectToAction("Index");
        }
       

    }
}
