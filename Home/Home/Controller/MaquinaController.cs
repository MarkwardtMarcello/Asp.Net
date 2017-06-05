using Home.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Controller
{
    public class MaquinaController
    {
        protected Model.BancoFerramentasContainer contexto = new BancoFerramentasContainer();

        public void Adicionar(Maquina maq)
        {
            if (maq != null)
            {
                contexto.Maquinas.Add(maq);
                contexto.SaveChanges();
            }
        }//fimADD

        public IList<Maquina> Listar()
        {
            return contexto.Maquinas.ToList();
        }//fimlista

        public Maquina BuscarMaquinaNome(string nome)
        {
            return contexto.Maquinas.Find(nome);
        }

        public void Excluir(Maquina maq)
        {
            contexto.Entry(maq).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();

        }
        public void Editar(Maquina m)
        {
            contexto.Entry(m).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

    }
}
