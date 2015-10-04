using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Medioteca.Models;

namespace Medioteca.Controllers
{
    public class CancionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Canciones
        public ActionResult Index()
        {
            return View(db.Cancions.ToList());
        }

        // GET: Canciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cancion cancion = db.Cancions.Find(id);
            if (cancion == null)
            {
                return HttpNotFound();
            }
            return View(cancion);
        }

        // GET: Canciones/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Canciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CancionId,Titulo,Artista,Album,Anio,Duracion,Estilo")] Cancion cancion)
        {
            if (ModelState.IsValid)
            {
                db.Cancions.Add(cancion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cancion);
        }

        // GET: Canciones/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cancion cancion = db.Cancions.Find(id);
            if (cancion == null)
            {
                return HttpNotFound();
            }
            return View(cancion);
        }

        // POST: Canciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CancionId,Titulo,Artista,Album,Anio,Duracion,Estilo")] Cancion cancion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cancion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cancion);
        }

        // GET: Canciones/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cancion cancion = db.Cancions.Find(id);
            if (cancion == null)
            {
                return HttpNotFound();
            }
            return View(cancion);
        }

        // POST: Canciones/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cancion cancion = db.Cancions.Find(id);
            db.Cancions.Remove(cancion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
