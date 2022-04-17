using Microsoft.AspNetCore.Mvc;
using williamZZ.Data;
using williamZZ.Models;

namespace williamZZ.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDBContext _db;

    public CategoryController(ApplicationDBContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        IEnumerable<Category> objCategoryList = _db.Categories.ToList();
        return View(objCategoryList);
    }

    //GET
    public IActionResult Create()
    {
        return View();
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Category obj)
    {
        if (ModelState.IsValid)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }
}
