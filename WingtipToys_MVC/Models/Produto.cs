﻿using System;
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

        [Required]
        public string Nome { get; set; }
        [Display(Name ="Descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required]
        [Display(Name ="Preço")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        public int CategoriaID { get; set; }

        public virtual Categoria categoria { get; set; }

        [Required]
        public bool Ativo { get; set; }


    }
}
