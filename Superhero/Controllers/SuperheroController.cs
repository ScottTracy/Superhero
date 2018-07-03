using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Superhero.Models;
using System.Data.Entity;


namespace Superhero.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext db= new ApplicationDbContext();
        // GET: Superhero
        public ActionResult Index()
        {
            var view = db.Superhero.ToList();

           
            return View(view);
        }
        //get
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Name,AlterEgo,PrimaryAbility,SecondaryAbility,Catchphrase")] Superheromodel superhero)
        {
            if (ModelState.IsValid)
            {
                db.Superhero.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        //get
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Superheromodel superhero = db.Superhero.Find(id);
            if (superhero == null)
            {
                return HttpNotFound();
            }
            return View(superhero);
            
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,Name,AlterEgo,PrimaryAbility,SecondaryAbility,Catchphrase")] Superheromodel superhero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(superhero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
                return View("index");
        }

    }
}