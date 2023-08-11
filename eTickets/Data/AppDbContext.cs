using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Ator_Filme>().HasKey(am => new
            {
                am.IdAtor,
                am.IdFilme
            });

            modelBuilder.Entity<Ator_Filme>().HasOne(m => m.Filme).WithMany(am => am.Atores_Filmes).HasForeignKey(m => m.IdFilme);

            modelBuilder.Entity<Ator_Filme>().HasOne(m => m.Ator).WithMany(am => am.Atores_Filmes).HasForeignKey(m => m.IdAtor);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Ator_Filme> Atores_Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Produtor> Produtores { get; set; }
    }
}

