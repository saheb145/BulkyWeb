using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CatogeryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CatogeryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Catogery>objCatogeryList=_db.catogeries.ToList();
            return View(objCatogeryList);
        }
    }
}
