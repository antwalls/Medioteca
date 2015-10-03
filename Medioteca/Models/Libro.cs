using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medioteca.Models
{
    public class Libro
    {
        
        public int          LibroId          { get; set; }
        public string       ISBM        { get; set; }
        public string       Autor       { get; set; }
        public string       Titulo      { get; set; }
        public DateTime     F_publi     { get; set; }
        public string       N_edicion   { get; set; }
        public string       N_paginas   { get; set; }
        public string       Argumento   { get; set; }

    }
}