using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace ProjetGestionTaches.Models
{ 
    class GestionTachesContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GestionTachesDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        } 
        public DbSet<Utilisateur>? Annuaire { get; set; }
        public DbSet<ElementRegistre>? Registre { get; set; }
    }
}