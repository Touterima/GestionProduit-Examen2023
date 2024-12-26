using GP_Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using GP_ApplicationCore.Domaine;
using GP_Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace GP_Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        //Les DbSet
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Chimique> Chimiques { get; set; }
        public DbSet<Biologique> Biologiques { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                Initial Catalog=GPDb;
                                Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new ProduitConfig());
            


            /*
            //TPH      2éme methode
            modelBuilder.Entity<Produit>()
                .HasDiscriminator<char>("TypeProduit")
                .HasValue<Produit>('P')
                .HasValue<Chimique>('C')
                .HasValue<Biologique>('B');
        */
        }




        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveMaxLength(50);
        }
    }
}