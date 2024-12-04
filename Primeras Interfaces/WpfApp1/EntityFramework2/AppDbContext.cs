using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class AppDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Evento> Eventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3307;Database=dbpersonas2;Uid=root;Pwd=root;",
                new MariaDbServerVersion(new Version(11, 5, 2)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasMany(p => p.EventosList)
                .WithMany(e => e.PersonasEventos)
                .UsingEntity<Dictionary<string, object>>(
                    "PersonasEventos",
                    j => j.HasOne<Evento>().WithMany().HasForeignKey("EventoId"),
                    j => j.HasOne<Persona>().WithMany().HasForeignKey("PersonaId"));
        }
    }

}
