using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CalderonExamen.Entidades;

    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<CalderonExamen.Entidades.Artista> Artista { get; set; } = default!;

        public DbSet<CalderonExamen.Entidades.Musica> Musica { get; set; } = default!;
    }
