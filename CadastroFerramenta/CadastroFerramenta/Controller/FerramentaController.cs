using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFerramenta.Controller
{
    public class FerramentaController
    {
        protected BancoFerramentasContainer contexto = new BancoFerramentasContainer();

        public void Adicionar(Ferramenta ferra)
        {
            if (ferra != null)
            {
                contexto.Ferramentas.Add(ferra);
                contexto.SaveChanges();
            }
        }//fimADD

        public List<Ferramenta> Listar()
        {
            return contexto.Ferramentas.ToList();
        }//fimlista

        public Ferramenta BuscarFerramentaNome(Ferramenta ferra)
        {
            return contexto.Ferramentas.Find(ferra);
        }

        public void Excluir(Ferramenta ferra)
        {
            contexto.Entry(ferra).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();

        }
        public void Editar(Ferramenta ferra)
        {
            contexto.Entry(ferra).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }
    }
}