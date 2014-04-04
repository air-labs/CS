using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture06.Models;

namespace Lecture06.Controllers
{ 
    public class ProjectsController : Controller
    {
        private DatabaseEntities db = new DatabaseEntities();

        //
        // GET: /Projects/

        public ViewResult Index()
        {
            return View(db.Projects.ToList());
        }

        //
        // GET: /Projects/Details/5

        public ViewResult Details(int id)
        {
            Projects projects = db.Projects.Single(p => p.Id == id);
            return View(projects);
        }

        //
        // GET: /Projects/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Projects/Create

        [HttpPost]
        public ActionResult Create(Projects projects)
        {
            if (ModelState.IsValid)
            {
                db.Projects.AddObject(projects);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(projects);
        }
        
        //
        // GET: /Projects/Edit/5
 
        public ActionResult Edit(int id)
        {
            Projects projects = db.Projects.Single(p => p.Id == id);
            return View(projects);
        }

        //
        // POST: /Projects/Edit/5

        [HttpPost]
        public ActionResult Edit(Projects projects)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Attach(projects);
                db.ObjectStateManager.ChangeObjectState(projects, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projects);
        }

        //
        // GET: /Projects/Delete/5
 
        public ActionResult Delete(int id)
        {
            Projects projects = db.Projects.Single(p => p.Id == id);
            return View(projects);
        }

        //
        // POST: /Projects/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Projects projects = db.Projects.Single(p => p.Id == id);
            db.Projects.DeleteObject(projects);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}