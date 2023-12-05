using GA.ApplicationCore.Domain;
using GA.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class DossierController : Controller
    {
        private readonly IDossierService dossierService;
        private readonly IAvocatService avocatService;
        private readonly IClientService clientService;

        public DossierController(IDossierService dossierService,IAvocatService avocatService,IClientService clientService)
        {
            this.dossierService = dossierService;
            this.clientService = clientService;
            this.avocatService = avocatService;

        }

        // GET: DossierController
        public ActionResult Index()
        {
            return View(dossierService.GetMany().ToList());
        }
        [HttpPost]
        public ActionResult Index(string nom)
        {
            if(!string.IsNullOrEmpty(nom))
                return View(dossierService.GetMany().ToList().Where(d=>d.Avocat.Nom.Equals(nom)));
            else
                return View(dossierService.GetMany().ToList());
        }

        // GET: DossierController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DossierController/Create
        public ActionResult Create()
        {
            var clients = clientService.GetMany().Select(a => new { a.CIN, a.NomPrenom });
            var avocat = avocatService.GetMany().Select(a=>new{a.AvocatId, a.NomPrenom });
            ViewBag.ClientFK=new SelectList(clients, "CIN", "NomPrenom");
            ViewBag.AvocatFK=new SelectList(avocat, "AvocatId", "NomPrenom");
            return View();
        }

        // POST: DossierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dossier collection)
        {
            try
            {
                dossierService.Add(collection);
                dossierService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DossierController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DossierController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DossierController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DossierController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
