

namespace Ivan.LojaTudoEletro.Domain.Entities
{
    public class Imagem
    {
        public int ImagemId { get; set; }

        public bool ehPrincipal { get; set; }

        public string UrlImagem { get; set; }

        public int? ProductID { get; set; }

        public virtual Product Product { get; set; }

    }
}


