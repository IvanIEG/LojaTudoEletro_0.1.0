﻿using System.Collections.Generic;
using System.Linq;
using Ivan.LojaTudoEletro.Domain.Entities;
using Ivan.LojaTudoEletro.Infra.Data.Repositories.Interfaces;

namespace Ivan.LojaTudoEletro.Infra.Data.Repositories
{
    public class ProductRepository: RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> BuscarPorNome(string nome)
        {
            return Db.Products.Where(p => p.Name == nome);
        }

        /// <summary>
        /// Método responsável por trazer produtos com desconto
        /// </summary>
        /// <returns>Lista de produtos com desconto</returns>
        public IEnumerable<Product> BuscarProdutosComDesconto()
        {
            return Db.Products.Where(p => p.Selloff == true);
        }
    }
}
