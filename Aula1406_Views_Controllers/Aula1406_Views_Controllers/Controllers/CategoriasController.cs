using Aula1406_Views_Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula1406_Views_Controllers.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias(carregamento da pagina)
        public ActionResult Index()
        {

            List<Categoria> categorias = new List<Categoria>();
                      
            //Retornar a lista de objetos cadastrados
            return View(categorias);
        }

        public ActionResult Create() //GET - carregar pagina
        {
            return View();
        }

        [HttpPost] // pag carregada
        public ActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                //objeto é valido, podendo ir para o banco.

            }

            return View(categoria);

        }

        //get editar
        public ActionResult Edit(int? id)
        {
            //carregar a tela
            //verificar se veio a ID, badresquest mal feita
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                //erro 400.0
            }
            //pesquisa no banco, o objeto a editar
            Categoria categoria = new Categoria()
            {
                CategoriaID = id.Value,
                Nome = "Carros",
                Descricao = "Veloz",
                Ativo = true
            };


            //se nao foi encontrado no banco
            if (categoria == null)
            {
                return HttpNotFound();
                //erro 404
            }

            return View(categoria);
        }
        //Post
        public ActionResult Edit(Categoria categoria)

        {
            if (ModelState.IsValid)
            {
                //Receber e guardar!
                
                try
                {
                    //update
                    //redirecionar
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            return View(categoria);
        }

        //get excluir
        public ActionResult Delete(int ? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = new Categoria()
            {
                CategoriaID = id.Value,
                Nome = "Motos",
                Descricao = "1000cc",
                Ativo = true
            };


            if (categoria == null)
            {
                return HttpNotFound();
            }

            return View(categoria);
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //pesquisar obj por id

            // alterar status do obj para deleted ou ativo para false

            TempData["Mensagem "] = "Categoria excluida !";
             return RedirectToAction("Index");

        }


    }
}