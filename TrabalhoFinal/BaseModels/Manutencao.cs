using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    public  class Manutencao
    {
        [Key]
        public int ManutencaoID { get; set; }
        [Required(ErrorMessage = "Inserir Nome do responsavel!!")]
        [Display(Name = "Nome: ")]
        public string NomeFuncionario { get; set; }

        [Required(ErrorMessage = "Adicionar custo da Ferramenta")]
        [Display(Name = "Custo")]
        public decimal Custo { get; set; }

        public bool Nova { get; set; }
                
        public bool Polimento { get; set; }

        public bool Retifica { get; set; }

        public int ProdutoID { get; set; }

        public virtual Produto produto { get; set; }
    }
}
