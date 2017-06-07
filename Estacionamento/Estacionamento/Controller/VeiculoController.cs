using Estacionamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estacionamento.Controller
{
    public class VeiculoController
    {
        protected BancoEstarContainer contexto = new BancoEstarContainer();

        public void Adicionar(Veiculo v)
        {
            if (v != null)
            {
                contexto.Veiculos.Add(v);
                contexto.SaveChanges();
            }
        }//fimADD

        public List<Veiculo> Listar()
        {
            return contexto.Veiculos.ToList();
        }//fimlista

        public Veiculo BuscarVeiculo(string v)
        {
            //return contexto.Veiculos.Find(v);
            return contexto.Veiculos.FirstOrDefault(n => n.Modelo.Equals(v));
        }

        public void Excluir(Veiculo v)
        {
            contexto.Entry(v).State =
                System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();

        }
        public void Editar(Veiculo v)
        {
            contexto.Entry(v).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

    }
}