using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Ferramentas.Models;
using BaseModels;

namespace Ferramentas
{
    public class ManutencoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Manutencaos
        public ActionResult Index()
        {
            var manutencoes = db.Manutencoes.Include(m => m.produto);
            return View(manutencoes.ToList());
        }

        // GET: Manutencaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manutencao manutencao = db.Manutencoes.Find(id);
            if (manutencao == null)
            {
                return HttpNotFound();
            }
            return View(manutencao);
        }

        // GET: Manutencaos/Create
        public ActionResult Create()
        {
            ViewBag.ProdutoID = new SelectList(db.Produtos, "ProdutoID", "ProdutoID");
            return View();
        }

        // POST: Manutencaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ManutencaoID,NomeFuncionario,Custo,Nova,Polimento,Retifica,ProdutoID")] Manutencao manutencao)
        {
            if (ModelState.IsValid)
            {
                db.Manutencoes.Add(manutencao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            // mudei produtoID para matricula.
            ViewBag.ProdutoID = new SelectList(db.Produtos, "ProdutoID", "ProdutoID", manutencao.ProdutoID);
            return View(manutencao);
        }

        // GET: Manutencaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manutencao manutencao = db.Manutencoes.Find(id);
            if (manutencao == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProdutoID = new SelectList(db.Produtos, "ProdutoID", "ProdutoID", manutencao.ProdutoID);
            return View(manutencao);
        }

        // POST: Manutencaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ManutencaoID,NomeFuncionario,Custo,Nova,Polimento,Retifica,ProdutoID")] Manutencao manutencao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manutencao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProdutoID = new SelectList(db.Produtos, "ProdutoID", "ProdutoID", manutencao.ProdutoID);
            return View(manutencao);
        }

        // GET: Manutencaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manutencao manutencao = db.Manutencoes.Find(id);
            if (manutencao == null)
            {
                return HttpNotFound();
            }
            return View(manutencao);
        }

        // POST: Manutencaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Manutencao manutencao = db.Manutencoes.Find(id);
            db.Manutencoes.Remove(manutencao);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
