using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }

        

        [Required(ErrorMessage = "Inserir Matricula!!")]
        [Display(Name = "Matrícula da peça: ")]
        public int Matricula { get; set; }

       
        [Required(ErrorMessage = "Inserir Diametro")]
        [Display(Name ="Diâmetro: ")]
        public bool Diametro { get; set; }

        [Required(ErrorMessage ="Informar Produção Total da ferramenta")]
        [Display(Name ="Total de produção por ferramenta")]
        public int Producao { get; set; }

        





    }
}
