using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Infra.Data.Contexto;
using ProjetoModeloDDD.Infra.Data.Repositories.Interfaces;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProductRepository: RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> BuscarPorNome(string nome)
        {
            return Db.Products.Where(p => p.Name == nome);
        }
    }
}
