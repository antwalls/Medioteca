namespace Medioteca.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Medioteca.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Medioteca.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            DateTime harry_potter = DateTime.Now;
            DateTime simmarillion = DateTime.Now;
            DateTime viento       = DateTime.Now;

            context.Libroes.AddOrUpdate(
                 p => p.Titulo,
                 new Libro { Titulo = "Harry potter y las reliquias de la muerte", Autor = "J.K Rowling", ISBM = 12345, F_publi = harry_potter, N_edicion = 1, N_paginas = 575, Argumento = "Adolescente cabeza rajada" },
                 new Libro { Titulo = "El Simmarillion", Autor = "R.J Tolkien", ISBM = 54321, F_publi = simmarillion, N_edicion = 23, N_paginas = 2000, Argumento = "Cosmología del mundo de Tolkien " },
                 new Libro { Titulo = "El nombre del viento", Autor = "Patrick Rothfuss", ISBM = 112233, F_publi = viento , N_edicion = 4, N_paginas = 345, Argumento = "No lo he leido" } 
                 );
            context.Cancions.AddOrUpdate(
                 p => p.Titulo,
                 new Cancion { Titulo = "Feroz", Artista = "Radio Focaccia", Anio = 2015, Duracion = 2, Album = "Feroz", Estilo = "Indie" },
                 new Cancion { Titulo = "Pull me Under", Artista = "Dream Theater", Anio = 1992, Duracion = 3, Album = "Images and Words", Estilo = "Metal Progresivo" },
                 new Cancion { Titulo = "Soap on a Rope", Artista = "Chickenfoot", Anio = 2010, Duracion = 4, Album = "Chickenfoot II", Estilo = "Hard Rock" },
                 new Cancion { Titulo = "Every summer night", Artista = "Patt Metheny", Anio = 1992, Duracion = 3, Album = "Letter From Home", Estilo = "Jazz" }
                 );
            context.Peliculas.AddOrUpdate(
                p => p.Titulo,
                new Pelicula { Titulo = "El señor de los anillos, La comunidad del anillo", Director = "Peter jackson", Reparto = "Ellyjah Wood", Duracion = 2.06 , Sinopsis = "anillos y mediandos y elfos y enanos y hombres y ..." },
                new Pelicula { Titulo = "La naranja mecanica", Director = "Stanley Krubrik", Reparto = "Malcolm Mcdowell", Duracion = 2.17, Sinopsis = "Conductismo" },
                new Pelicula { Titulo = "Pulp Fiction", Director = "Quentin Tarantinno", Reparto = "Samuel L.Jackson, John Travolta, Uma Thurman", Duracion = 2.57, Sinopsis = "4 historias" }

                );


        }
    }
}
