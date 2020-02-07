using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace EEstoque.Model
{
    
    public class Estoque
    {        
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Produto")]
        public string Produto { get; set; }

        [Display(Name = "Fornecedor")]
        public string Fornecedor { get; set; }

        [Required]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Proporção")]
        public Proporcao Proporcao { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Validade")]
        public DateTime Validade { get; set; }
    }
}
