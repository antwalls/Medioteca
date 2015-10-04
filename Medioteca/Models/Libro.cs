using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Medioteca.Models
{
    public class Libro
    {
        [Required]
        [Key]
        public int          LibroId     { get; set; }

        public int          ISBM        { get; set; }
        public string       Autor       { get; set; }
        public string       Titulo      { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de publicacion")]
        public DateTime     F_publi     { get; set; }

        [Display(Name = "Edicion numero")]
        public int          N_edicion   { get; set; }

        [Display(Name = "Numero de paginas")]
        public int          N_paginas   { get; set; }

        public string       Argumento   { get; set; }

    }
}