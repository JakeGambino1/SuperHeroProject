using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnotherSuperHeroProject.Models;

namespace AnotherSuperHeroProject.Controllers
{
    public class SuperHeroesController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: SuperHeroes
        public ActionResult Index()
        {
            var listOfHeroes = db.SuperHeroes.ToList();
            return View(listOfHeroes);
        }

        // GET: SuperHeroes/Details/5
        public ActionResult Details(int id)
        {
            SuperHero superHero = db.SuperHeroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superHero);
        }

        // GET: SuperHeroes/Create
        public ActionResult Create()
        {
            SuperHero newSuperHero = new SuperHero();
            return View(newSuperHero);
        }

        // POST: SuperHeroes/Create
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                // TODO: Add insert logic here
                db.SuperHeroes.Add(superHero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroes/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superHero = db.SuperHeroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superHero);
        }

        // POST: SuperHeroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero superHero)
        {

                // TODO: Add update logic here
                SuperHero editSuperHero = db.SuperHeroes.Find(id);
                editSuperHero.Name = superHero.Name;
                editSuperHero.AlterEgo = superHero.AlterEgo;
                editSuperHero.PrimaryPower = superHero.PrimaryPower;
                editSuperHero.SecondaryPower = superHero.SecondaryPower;
                editSuperHero.Catchphrase = superHero.Catchphrase;
                db.SaveChanges();
                return RedirectToAction("Index");

        }

        // GET: SuperHeroes/Delete/5
        public ActionResult Delete(int id)
        {
            SuperHero superHero = db.SuperHeroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superHero);
        }

        // POST: SuperHeroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHero superHero)
        {
            try
            {
                db.SuperHeroes.Remove(db.SuperHeroes.Find(id));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
