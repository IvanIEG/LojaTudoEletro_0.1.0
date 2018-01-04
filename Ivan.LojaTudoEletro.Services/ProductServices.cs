using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Método responsável por trazer produtos com desconto que serão mostrados na tela inicial.
        /// </summary>
        /// <returns>Lista de produtos com desconto(Sellof==true)</returns>
        public IEnumerable<Product> ReturnProductsSellof()

        {
            return _IproductRepository.GetAll().Where(p => p.Selloff == true).ToList();
        }



    }
}
