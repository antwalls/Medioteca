using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Medioteca.Models
{
    public class Cancion
    {
        [Required]
        [Key]
        public int          CancionId   { get; set; }
        public string       Titulo      { get; set; }
        public string       Artista     { get; set; }
        public string       Album       { get; set; }

        [Range(1914,int.MaxValue)]
        [Display(Name = "Año")]
        public int          Anio        { get; set;}

        public double       Duracion    { get; set; }
        public string       Estilo      { get; set; }

    }
}