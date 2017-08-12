using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;

namespace SonOfCod.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly SonOfCodDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(UserManager<ApplicationUser> userManager, SonOfCodDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Subscribers()
        {
            return View(_db.Subscribers.ToList());
        }
    }
}
