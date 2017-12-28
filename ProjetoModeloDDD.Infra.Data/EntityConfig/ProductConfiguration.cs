using System.Data.Entity.ModelConfiguration;
using Ivan.LojaTudoEletro.Domain.Entities;
using JetBrains.ReSharper.Feature.Services.Html;

namespace Ivan.LojaTudoEletro.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ProductId);
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Price)
                .IsRequired();
            Property(p => p.ClienteId)
                .IsOptional();
            //relacionamento cliente tem vários produtos
            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
        }
    }
}
