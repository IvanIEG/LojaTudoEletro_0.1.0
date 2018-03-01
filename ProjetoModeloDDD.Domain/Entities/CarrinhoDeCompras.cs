using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.LojaTudoEletro.Domain.Entities
{
    public class CarrinhoDeCompras
    {
        public List<Product> Products { get; set; }

        public CarrinhoDeCompras()
        {
            this.Products = new List<Product>();
        }
    }
}
