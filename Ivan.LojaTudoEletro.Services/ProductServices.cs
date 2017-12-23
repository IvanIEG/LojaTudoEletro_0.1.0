using System.Collections.Generic;
using Ivan.LojaTudoEletro.Domain.Entities;
using Ivan.LojaTudoEletro.Infra.Data.Repositories;


namespace Ivan.LojaTudoEletro.Services
{
    public class ProductServices
    {

        public List<Product> ReturnProductsSellof()
        {
           

            using (var productRepository = new ProductRepository())
            {
               var products = new List<Product>();

               return  products = (List<Product>) productRepository.BuscarProdutosComDesconto();


            }

          



        }

    }
}
