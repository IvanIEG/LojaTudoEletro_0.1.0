using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.ViewsModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo {0 caracteres.}")]

        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo Sobrenome.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo {0 caracteres.}")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo email.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [EmailAddress(ErrorMessage = "Digite um email válido")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}