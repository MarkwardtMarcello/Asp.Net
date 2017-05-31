using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Home.Model; 

namespace Home.Controller
{
    public class FerramentaController
    {
        protected BancoFerramentasContainer contexto = new BancoFerramentasContainer();
        
        public void Adicionar (Ferramenta ferra)
        {
            if (ferra != null)
            {
                contexto.Ferramentas.Add(ferra);
                contexto.SaveChanges();
            }
        }//fimADD

        public IList<Ferramenta> Listar()
        {
            return contexto.Ferramentas.ToList();
        }//fimlista

        public Ferramenta BuscarFerramentaNome(string nome)
        {
            return contexto.Ferramentas.Find(nome);
        }

        public void Excluir(Ferramenta ferra)
        {
            contexto.Entry(ferra).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();

        }

    }
}