using System.Collections.Generic;
using Ivan.LojaTudoEletro.Domain.Entities;

using Ivan.LojaTudoEletro.Services.Interfaces;


namespace Ivan.LojaTudoEletro.Services
{
    public class ProductServices : IServicesBase
    {
        private IProductRepository iProductRepository;

        public ProductServices(IProductRepository _iProductRepository)
        {
            this.iProductRepository = _iProductRepository;
        }


        public List<Product> ReturnProductsSellof()

        {
            var products = new List<Product>();
            return products = iProductRepository.ReturnProductsSellof();


        }

        public void Dispose()
        {

        }
    }
}
