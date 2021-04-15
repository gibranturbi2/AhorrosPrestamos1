using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AhorrosPrestamos1.Models;

namespace AhorrosPrestamos1.Controllers
{
    public class AhorrosController : Controller
    {
        private MigracionDbContext db = new MigracionDbContext();

        // GET: Ahorros
        public ActionResult Index()
        {
            return View(db.ahorros.ToList());
        }

        // GET: Ahorros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ahorros ahorros = db.ahorros.Find(id);
            if (ahorros == null)
            {
                return HttpNotFound();
            }
            return View(ahorros);
        }

        // GET: Ahorros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ahorros/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Saving,Name,Last_Name,Nationality,Identification,Material_Status,Phone_Number,Home_Phone,Email,Address,Account_type,Currency")] Ahorros ahorros)
        {
            if (ModelState.IsValid)
            {
                db.ahorros.Add(ahorros);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ahorros);
        }

        // GET: Ahorros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ahorros ahorros = db.ahorros.Find(id);
            if (ahorros == null)
            {
                return HttpNotFound();
            }
            return View(ahorros);
        }

        // POST: Ahorros/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Saving,Name,Last_Name,Nationality,Identification,Material_Status,Phone_Number,Home_Phone,Email,Address,Account_type,Currency")] Ahorros ahorros)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ahorros).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ahorros);
        }

        // GET: Ahorros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ahorros ahorros = db.ahorros.Find(id);
            if (ahorros == null)
            {
                return HttpNotFound();
            }
            return View(ahorros);
        }

        // POST: Ahorros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ahorros ahorros = db.ahorros.Find(id);
            db.ahorros.Remove(ahorros);
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
