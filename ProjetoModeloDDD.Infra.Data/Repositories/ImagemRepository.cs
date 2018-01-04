using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ivan.LojaTudoEletro.Infra.Data.Repositories
{
    public class ImagemRepository
    {
        public int ImagemId { get; set; }

        public static int _inc { get; set; }

        public string Nome { get; set; }

        public string Conteudo { get; set; }

        public string Tipo { get; set; }

        public int Tamanho { get; set; }

    }

}
