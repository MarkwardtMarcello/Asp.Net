using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1505Aula
{
    public class Projeto
    {
        [Key]
        public int ProjetoID { get; set; }

        public string Nome { get; set; }
        [Display(Name="Descrição"), DataType(DataType.MultilineText)]

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

    }
}