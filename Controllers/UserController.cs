using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieRank.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return PartialView("Details");
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return PartialView("Create");
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return PartialView("Create");
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return PartialView("Edit");
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return PartialView("Edit");
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return PartialView("Delete");
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return PartialView("Delete");
            }
        }
        
        // GET: User/Profile/5
        public ActionResult Profile(int id)
        {
            return PartialView("Profile");
        }
        
    }
}