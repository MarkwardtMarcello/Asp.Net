using Aula1406_Views_Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return View();
        }
        //Post
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                //Receber e guardar!
                //update
            }
            return View(categoria);
        }


    }
}