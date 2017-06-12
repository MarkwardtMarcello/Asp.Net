using aula1206.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula1206.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(new Categoria() { Nome = "Carros", Descricao="Super carros do momento", Ativo=true });
            categorias.Add(new Categoria() { Nome = "Motos", Descricao="As mais estilosas do mundo"});
            categorias.Add(new Categoria() { Nome = "Barcos", Descricao="Super lançamentos de 2017"});
            categorias.Add(new Categoria() { Nome = "Aviões", Descricao="Aviões do exercito" });
            categorias.Add(new Categoria() { Nome = "Caminhões", Descricao="Varias marcas" });
                

            ViewBag.ListaCategorias = categorias;

            return View(categorias);
        }

        //GET
        public ActionResult Create()
        {
            return View(); 
        }
        
        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            return View(categoria);
        }
    }
}