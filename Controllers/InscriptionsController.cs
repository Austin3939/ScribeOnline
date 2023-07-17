﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Inscript_v5.Data.Inscriptions;
using Inscript_v5.Models;

namespace Inscript_v5.Controllers
{
    public class InscriptionsController : Controller
    {
        private Inscriptv4Entities db = new Inscriptv4Entities();

        // GET: Inscriptions
        public ActionResult Index()
        {
            return View(InscriptionsData.GetList());
        }

        // GET: Inscriptions/Details/5
        public ActionResult Details(int id)
        {
           
            if (Session["UserID"] != null)
            {
                var user = (int)Session["UserID"];
                ViewBag.LoggedIn = true;
                var saved = UserInscriptionsData.GetList().Where(x => x.UserID == user && x.InscriptionID == id).FirstOrDefault();
                if (saved != null)
                {
                    ViewBag.IsSaved = true;
                }
                else
                {
                    ViewBag.IsSaved = false;
                };
                
            }
            else
            {
                ViewBag.LoggedIn = false;
                ViewBag.IsSaved = false;
            }

           InscriptionsModel inscriptions = InscriptionsData.Get(id);
            if (inscriptions == null)
            {
                return HttpNotFound();
            }
           
            return View(inscriptions);
        }

        public ActionResult SaveInscription(int id)
        {
            var UserID = (int)Session["UserID"];
            UserInscriptionsData.Insert(UserID, id);
            return View();
        }
        public ActionResult RemoveInscription(int id)
        {
            var UserID = (int)Session["UserID"];
            UserInscriptionsData.Remove(UserID, id);
            return View();
        }

        // GET: Inscriptions/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.NextView = false;
            return View(); 
        }

        // POST: Inscriptions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InscriptionsModel inscription)
        {
            if (ModelState.IsValid)
            {
                InscriptionsModel model = InscriptionsData.Insert(inscription);
                inscription.InscriptionID = model.InscriptionID;
                ViewBag.NextView = true;
            }

            return View(inscription);
        }

        // GET: Inscriptions/Edit/5
        public ActionResult Edit(int id)
        {
       
            var inscription = InscriptionsData.Get(id);
            if (inscription == null)
            {
                return HttpNotFound();
            }
           
            return View(inscription);
        }

        // POST: Inscriptions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InscriptionsModel inscription)
        {
            if (ModelState.IsValid)
            {
                InscriptionsData.Update(inscription);
                return RedirectToAction("Index");
            }
            
            return View(inscription);
        }

        // GET: Inscriptions/Delete/5
        public ActionResult Delete(int id)
        {
            var inscription = InscriptionsData.Get(id);
            if (inscription == null)
            {
                return HttpNotFound();
            }
            return View(inscription);
        }

        // POST: Inscriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var inscription = InscriptionsData.Get(id);
            InscriptionsData.Delete(inscription);
            
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SelectRecent()
        {
            return PartialView(InscriptionsData.SelectRecent());
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
