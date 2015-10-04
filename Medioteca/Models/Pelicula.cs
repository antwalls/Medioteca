using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Medioteca.Models
{
    public class Pelicula
    {
        [Required]
        [Key]
        public int      PeliculaID  { get; set; }
        public string   Director    { get; set; }
        public string   Titulo      { get; set; }
        public string   Reparto     { get; set; }
        public string   Sinopsis    { get; set; }
        [Range(0,5)]
        public double   Duracion    { get; set; }


    }
}