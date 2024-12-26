using GP_ApplicationCore.Domaine;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_Infrastructure.Configuration
{
    public class ProduitConfig : IEntityTypeConfiguration<Produit>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Produit> builder)
        {
            builder.HasOne(p=>p.Categorie)  
                .WithMany(c=>c.Produits)
                .HasForeignKey(p => p.CategorieFk)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Fournisseurs)
                .WithMany(f => f.Produits)
                .UsingEntity(p=>p.ToTable("Facture"));

            //TPH      1ere methode
            builder.HasDiscriminator<char>("TypeProduit")
                .HasValue<Produit>('P')
                .HasValue<Chimique>('C')
                .HasValue<Biologique>('B');
        }
    }
}
