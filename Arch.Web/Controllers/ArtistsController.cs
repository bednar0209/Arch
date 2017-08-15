using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Arch.Model;
using Arch.Service;

namespace Arch.Web.Controllers
{
    public class ArtistsController : Controller
    {
        IArtistService _artistService;

        public ArtistsController(IArtistService service)
        {
            _artistService = service;
        }

        // GET: Artists
        public ActionResult Index()
        {
            return View(_artistService.GetAll());
        }

        // GET: Artists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = _artistService.GetAll().Where(x=>x.Id == id.Value).FirstOrDefault();
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // GET: Artists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,BirthDate,Nationality")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                _artistService.Persist(artist);
                return RedirectToAction("Index");
            }

            return View(artist);
        }

        // GET: Artists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = _artistService.GetAll().Where(x => x.Id == id.Value).FirstOrDefault();
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,BirthDate,Nationality")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                _artistService.Persist(artist);
                return RedirectToAction("Index");
            }
            return View(artist);
        }

        // GET: Artists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = _artistService.GetAll().Where(x => x.Id == id.Value).FirstOrDefault();
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artist artist = _artistService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            _artistService.Delete(artist);
            return RedirectToAction("Index");
        }

    }
}
