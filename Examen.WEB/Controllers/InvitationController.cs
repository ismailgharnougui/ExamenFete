using Examen.ApplicationCore.Domaine;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.WEB.Controllers
{
    public class InvitationController : Controller
    {  //1-  creation de l'instance ServiceInvitation
        IServiceInvitation ServiceInvitation;
        IServiceFete ServiceFete;
        IServiceInvite ServiceInvite;

        public InvitationController(IServiceInvitation serviceInvitation, IServiceFete serviceFete, IServiceInvite serviceInvite)
        {
            ServiceInvitation = serviceInvitation;
            ServiceFete = serviceFete;
            ServiceInvite = serviceInvite;
        }

        // GET: InvitationController
        public ActionResult Index()
        {
            return View(ServiceInvite.GetAll());
        }

        // GET: InvitationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InvitationController/Create
        public ActionResult Create()
        {
            ViewBag.FeteList = new SelectList(ServiceFete.GetAll(), "FeteId", "Description");
            ViewBag.InviteList = new SelectList(ServiceInvite.GetAll(), "InviteId", "Prenom");

            return View();
        }

        // POST: InvitationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Invitation collection)
        {
            try
            {
                ServiceInvitation.Add(collection);
                ServiceInvitation.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvitationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvitationController/Edit/5
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

        // GET: InvitationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvitationController/Delete/5
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
