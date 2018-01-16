using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.ViewsModels
{
    public class ImagemViewModel
    {
        [Key]
        public int ImagemId { get; set; }

        public bool ehPrincipal { get; set; }

        public string UrlImagem { get; set; }

        public int? ProductID { get; set; }

        public virtual ProductViewModel Product { get; set; }
    }
}