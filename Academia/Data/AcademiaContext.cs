using Academia.Moldls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Data
{
    public class AcademiaContext : DbContext
    {
        public DbSet <Inscripto> inscriptos { get; set; }
        public DbSet<Ritmo> Ritmos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        
        public AcademiaContext()
        {
            
        }
        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cadenaConexion = "Server=.\\SQLEXPRESS ; User Id=sa ; Password=123 ; Database=AcademiaContext; MultipleActiveResultSets = True; Encrypt=False ";
            optionsBuilder.UseSqlServer(cadenaConexion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscripto>().HasData(new Inscripto { Id = 1, Nombre = "Sofia", Edad = "21" }, new Inscripto { Id = 2, Nombre = "Lara", Edad = "21" }
            );
            modelBuilder.Entity<Ritmo>().HasData(new Ritmo { Id = 1, Nombre = "Clasico" }, new Ritmo { Id = 2, Nombre = "Cumbia"}
            );
            modelBuilder.Entity<Profesor>().HasData(new Profesor { Id = 1, Nombre = "Maria" }, new Profesor { Id = 2, Nombre = "Karen" }
            );
            
            
           
            
        }
        
    }
}
