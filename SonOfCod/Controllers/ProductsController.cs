using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

namespace SonOfCod.Controllers
{
    public class ProductsController : Controller
    {
        private SonOfCodDbContext db = new SonOfCodDbContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}
