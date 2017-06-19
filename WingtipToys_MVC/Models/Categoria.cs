using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    public class Categoria
    {

        [Key]
        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "Inserir Nome!!"),
            StringLength(10, ErrorMessage = "Tamanho maximo é 10 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição"),
            DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}
