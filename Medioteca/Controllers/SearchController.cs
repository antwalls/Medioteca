using Medioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medioteca.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        // Post: Results
        public ActionResult Results(string searchString)
        {
            //seleccionamos todos los libros que contengan en su nombre la cadena de busqueda
            var books = from m in db.Libroes select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Titulo.Contains(searchString));
            }
            //lo mismo con las peliculas
            var movies = from m in db.Peliculas select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Titulo.Contains(searchString));               
            }
            //lo mismo con las canciones
            var songs = from m in db.Cancions select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                songs = songs.Where(s => s.Titulo.Contains(searchString));
            }

            ViewBag.books   = books;
            ViewBag.movies  = movies;
            ViewBag.songs   = songs;
          
            return View();
        }


    }
}