using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Ivan.LojaTudoEletro.Domain.Entities;
using Ivan.LojaTudoEletro.Infra.Data.EntityConfig;

namespace Ivan.LojaTudoEletro.Infra.Data.Contexto
{
    public class ProjetoModeloContexto : DbContext
        
    {
        public ProjetoModeloContexto()
            :base("ProjetoModeloContexto")
        {
            
        }
        

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Product> Products { get; set; }
  

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
               .Where(p => p.Name == p.ReflectedType.Name + "Id")
               .Configure(p => p.IsKey());

            modelBuilder.Properties<String>()
            .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<String>()
            .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }


}
