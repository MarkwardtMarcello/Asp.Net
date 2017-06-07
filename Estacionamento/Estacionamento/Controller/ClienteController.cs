using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Estacionamento.Model;

namespace Estacionamento.Controller
{
    public class ClienteController
    {
        protected BancoEstarContainer contexto = new BancoEstarContainer();

        public void Adicionar(Cliente cliente)
        {
            if(cliente != null)
            {
                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
            }
        }

        public  List<Cliente> Listar()
        {
            return contexto.Clientes.ToList();
        }

        public Cliente BuscarCliente(string cliente)
        {
            //return contexto.Clientes.Find(cliente);
            return contexto.Clientes.FirstOrDefault(c => c.Nome.Equals(cliente));

        }

        public void Excluir(Cliente cliente)
        {
            contexto.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public void Editar(Cliente cliente)
        {
            contexto.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

    }
}