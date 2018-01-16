using System.Data.Entity.ModelConfiguration;
using Ivan.LojaTudoEletro.Domain.Entities;

namespace Ivan.LojaTudoEletro.Infra.Data.EntityConfig
{
   public  class ImagemConfiguration: EntityTypeConfiguration<Imagem>
    {

        public ImagemConfiguration()
        {
            HasKey(p => p.ImagemId);
          
           
        }
    }
}
