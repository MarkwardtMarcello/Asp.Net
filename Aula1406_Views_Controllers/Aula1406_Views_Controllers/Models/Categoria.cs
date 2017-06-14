
using System.ComponentModel.DataAnnotations;

namespace Aula1406_Views_Controllers.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        [Required (ErrorMessage="Favor preencher o campo nome!")]
        public string Nome { get; set; }
        [Display (Name="Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        [Required]
        public bool Ativo { get; set; }

    }
}