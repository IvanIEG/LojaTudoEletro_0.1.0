using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Ivan.LojaTudoEletro.Domain.Entities;

namespace Ivan.LojaTudoEletro.Infra.Data.Repositories.Interfaces
{
    public interface IImagemRepository
    {
        void Create(Imagem imagem);
        void Delete(int id);
        void DeleteConfirmed(int id);
        void BuscarAnexoImagemPorNome(string nomeImagem);
        FileContentResult CriarAnexoImagem(string nomeImagem);
    }
}
