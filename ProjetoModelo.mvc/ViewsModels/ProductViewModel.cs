using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.ViewsModels
{
    public class ProductViewModel
    {


        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome.")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres.")]
        [DisplayName("Nome: ")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Preencha um valor")]
        [DisplayName("Preço: ")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Preencha o campo descrição.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        [DisplayName("Breve descrição: ")]
        public string Description { get; set; }


        [ScaffoldColumn(false)]
        public virtual List<ImagemViewModel> Imagens { get; set; }

        [Required(ErrorMessage = "Preencha o campo detalhes do produto.")]
        [MaxLength(2250, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres.")]
        [DisplayName("Detalhes ")]
        public string Details { get; set; }

        [DisplayName("Será destacado como promoção?")]
        public bool Selloff { get; set; }

        [Required(ErrorMessage = "Insira ao menos uma foto.")]

        public virtual IEnumerable<HttpPostedFileBase> ImagensProduto { get; set; }

        [ScaffoldColumn(false)]
        public int? ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

        public ProductViewModel()
        {
            
            this.ImagensProduto = new List<HttpPostedFileBase>();
            this.Imagens = new List<ImagemViewModel>();
        }
    }
}


