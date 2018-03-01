using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;


namespace Ivan.LojaTudoEletro.Domain.Entities
{
    public class Product

    {
    
     
        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }


        public virtual List<Imagem> Imagens{ get; set; }
        

        public string Details { get; set; }

        public bool Selloff { get; set; }

        [NotMapped]
        public virtual List<HttpPostedFileBase> ImagensProduto { get; set; }
        //Campo pode ser nulo
        public int? ClienteId { get; set; }

        
        public virtual Cliente Cliente { get; set; }

        //ctor - atalho-ConstrutorPadrão
        public Product()
        {
      
        }


    }
}
