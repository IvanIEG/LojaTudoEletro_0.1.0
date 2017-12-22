using System.Data.Entity.ModelConfiguration;
using Ivan.LojaTudoEletro.Domain.Entities;

namespace Ivan.LojaTudoEletro.Infra.Data.EntityConfig
{
    public  class ClienteConfiguration: EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(150);

            Property(c => c.Email)
              .IsRequired();
        }
    }
}
