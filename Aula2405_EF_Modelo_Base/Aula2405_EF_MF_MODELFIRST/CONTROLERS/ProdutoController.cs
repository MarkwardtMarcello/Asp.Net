using Aula2405_EF_MF_MODELFIRST.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2405_EF_MF_MODELFIRST.CONTROLERS
{
    public class ProdutoController
    {
        protected BaseDadosContainer contexto = new BaseDadosContainer();

         public void Adicionar(Produto prod)
        {
            if (prod != null)
            {
                contexto.Produtos.Add(prod);
                contexto.SaveChanges();
            }
        }

        public List<Produto> Listar()
        {
            return contexto.Produtos.Where(c => c.Ativo == true).ToList();//retorna a lista completa
        }

        public IList<Produto> listarInativos()
        {
            return contexto.Produtos.Where(c => c.Ativo == false).ToList();
        }

        public Produto BuscarProdutoPorId(int id)
        {
            return contexto.Produtos.Find(id);//metodo especifico para buscar o id
        }

        ////exclusão fisica(apaga o registro do banco)
        //public void ExcluirProduto(Produto prod)
        //{
        //    contexto.Entry(prod).State = System.Data.Entity.EntityState.Deleted;
        //    contexto.SaveChanges();
        //}

        //exclusao logica(campo ativo/inativo)
        public void Excluir(Produto prod)
        {
            prod.Ativo = false;
            contexto.Entry(prod).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();

        }

        public void EditarCategoria(Produto prod)
        {
            contexto.Entry(prod).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }


    }
}