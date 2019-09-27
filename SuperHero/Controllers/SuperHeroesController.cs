using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuperHero.Models;

namespace SuperHero.Controllers
{
    public class SuperHeroesController : Controller
    {
        static ApplicationDbContext db = new ApplicationDbContext();
        // GET: SuperHero
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            ASuperHero superHeroResult = db.SuperHeroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superHeroResult);
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            ASuperHero newSuperHero = new ASuperHero();
            return View(newSuperHero);
        }

        // POST: SuperHero/Create
        [HttpPost]
        public ActionResult Create(ASuperHero superHero)
        {
            try
            {
                db.SuperHeroes.Add(superHero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            ASuperHero editSuperHero = db.SuperHeroes.Where(s => s.Id == id).SingleOrDefault();
            return View(editSuperHero);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ASuperHero superHero)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            ASuperHero superHero = db.SuperHeroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superHero);
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ASuperHero superHero)
        {
            try
            {
                db.SuperHeroes.Remove(superHero);
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
