

namespace Ivan.LojaTudoEletro.Domain.Entities
{
    public class Imagem
    {
        public int ImagemId { get; set; }

        public static int _inc { get; set; }

        public string Nome { get; set; }

        public string Conteudo { get; set; }

        public string Tipo { get; set; }

        public int Tamanho { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }


    }
}
