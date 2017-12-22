using System.Collections.Generic;
using Ivan.LojaTudoEletro.Domain.Entities;

namespace Ivan.LojaTudoEletro.Infra.Data.Repositories.Interfaces
{
   public  interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> BuscarPorNome(string nome);
    }
}
