

using Aula2405_EF_MF_MODELFIRST.MODELS;
using System.Collections.Generic;
using System.Linq;

namespace Aula2405_EF_MF_MODELFIRST
{
    public class CategoriasController
    {
        protected BaseDadosContainer contexto = new BaseDadosContainer();

        public void Adicionar(Categoria cat)
        {
            if (cat != null)
            {
                contexto.Categorias.Add(cat);
                contexto.SaveChanges();
            }
        }

        public List<Categoria> Listar()
        {
            return contexto.Categorias.Where(c => c.Ativo == true).ToList();//retorna a lista completa
        }

        public IList<Categoria> listarInativos()
        {
            return contexto.Categorias.Where(c => c.Ativo == false).ToList();
        }



        public Categoria BuscarCategoriaPorId(int id)
        {
            return contexto.Categorias.Find(id);//metodo especifico para buscar o id
        }

        ////exclusão fisica(apaga o registro do banco)
        //public void ExcluirCategoria(Categoria cat)
        //{
        //    contexto.Entry(cat).State = System.Data.Entity.EntityState.Deleted;
        //    contexto.SaveChanges();
        //}

        //exclusao logica(campo ativo/inativo)
        public void Excluir(Categoria cat)
        {
            cat.Ativo = false;
            contexto.Entry(cat).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();

        }


        public void EditarCategoria(Categoria cat)
        {
            contexto.Entry(cat).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}