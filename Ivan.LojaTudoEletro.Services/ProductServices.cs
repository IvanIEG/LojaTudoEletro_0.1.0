using System.Collections.Generic;
using Ivan.LojaTudoEletro.Domain.Entities;
using Ivan.LojaTudoEletro.Infra.Data.Repositories.Interfaces;
using Ivan.LojaTudoEletro.Services.Interfaces;


namespace Ivan.LojaTudoEletro.Services
{
    public class ProductServices : IServicesBase, IProductServices
    {
        private readonly IProductRepository _IproductRepository;

        public ProductServices(IProductRepository iProductRepository)
        {
            this._IproductRepository = iProductRepository;
        }


        public IEnumerable<Product> ReturnProductsSellof()

        {

            return _IproductRepository.BuscarProdutosComDesconto();


        }

        
    }
}
