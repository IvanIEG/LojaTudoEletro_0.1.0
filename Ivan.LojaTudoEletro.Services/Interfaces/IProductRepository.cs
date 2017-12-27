using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ivan.LojaTudoEletro.Domain.Entities;

namespace Ivan.LojaTudoEletro.Services.Interfaces
{
    public interface IProductRepository
    {
        List<Product> ReturnProductsSellof();
 }
}
