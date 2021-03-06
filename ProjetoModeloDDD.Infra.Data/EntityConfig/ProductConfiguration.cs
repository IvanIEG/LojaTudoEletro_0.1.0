﻿using System.Data.Entity.ModelConfiguration;
using Ivan.LojaTudoEletro.Domain.Entities;

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

            //relacionamento cliente tem vários produtos
            Property(p => p.ClienteId)
                .IsOptional();
        }
    }
}
