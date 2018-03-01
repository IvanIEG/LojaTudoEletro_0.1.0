using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Ivan.LojaTudoEletro.Infra.Data.Contexto;
using Ivan.LojaTudoEletro.Infra.Data.Repositories.Interfaces;

namespace Ivan.LojaTudoEletro.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoTudoEletroContexto Db = new ProjetoTudoEletroContexto();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }


    }
}
