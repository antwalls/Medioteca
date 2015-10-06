using Medioteca.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medioteca.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext context;

        public RoleController()
        {
            context = new ApplicationDbContext();
        }

        //GET: Get All Roles
       
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }


        //GET: Create  a New role

        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        //POST
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}