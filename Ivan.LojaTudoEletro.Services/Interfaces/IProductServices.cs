using System.Collections.Generic;
using Ivan.LojaTudoEletro.Domain.Entities;

namespace Ivan.LojaTudoEletro.Services.Interfaces
{
    public interface IProductServices
    {



        IEnumerable<Product> GetAllProducts();

        void AddProduct(Product product);

        Product GetProduct(int id);

        void DeleteProduct(Product product);

        void EditProduct(Product product);

        Product DetailsProduct(int id);

        IEnumerable<Product> GetLastsProductsSellofForSlider();
    }

}
