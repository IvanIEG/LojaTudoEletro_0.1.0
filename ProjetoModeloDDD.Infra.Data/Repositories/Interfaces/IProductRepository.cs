using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.Repositories.Interfaces
{
   public  interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> BuscarPorNome(string nome);
    }
}
