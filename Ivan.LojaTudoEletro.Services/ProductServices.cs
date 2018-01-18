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
        /// Retorna uma lista de todos os produtos cadastrados.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProducts()
        {

            return _IproductRepository.GetAll();
        }

        /// <summary>
        /// Persiste um produto populado ao banco de dados.
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            _IproductRepository.Add(product);
        }

        /// <summary>
        /// Retorna um produto de acordo com o id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProduct(int id)
        {
            return _IproductRepository.GetById(id);
        }
        /// <summary>
        /// Exclui um produto.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteProduct(Product product)
        {
            _IproductRepository.Remove(product);

        }

        /// <summary>
        /// Retorna detalhes do produto de ac
        /// </summary>
        /// <param name="product"></param>
        public Product DetailsProduct(int id)
        {
            return _IproductRepository.GetById(id);
        }

        /// <summary>
        /// Edita um produto de acordo com o id.
        /// </summary>
        /// <param name="product"></param>
        public void EditProduct(Product product)
        {
            _IproductRepository.Update(product);
        }

        /// <summary>
        /// Responsável por filtrar os últimos 3 ítens marcados como promoção para serem exibidos no slider da Home.
        /// </summary>
        /// <returns>Uma lista com os 3 últimos produtos destacados.</returns>
        public IEnumerable<Product> GetLastsProductsSellofForSlider()
        {
            var products = _IproductRepository.GetAll().Where(p => p.Selloff);

            var listProductSellof = new List<Product>();

            foreach (var product in products.Take(3).ToList())
            {
                foreach (var imagem in product.Imagens)
                {
                    if (imagem.ehPrincipal)
                    {
                        var productSellof = new Product();

                        productSellof = product;
                        //Retorna só a imagem principal do produto.
                        productSellof.Imagens.RemoveAll(i => i.ehPrincipal != true);

                        listProductSellof.Add(productSellof);
                    }

                }
            }


            return listProductSellof;
        }

    }
}
