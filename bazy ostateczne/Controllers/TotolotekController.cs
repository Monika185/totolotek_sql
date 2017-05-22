using bazy_ostateczne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bazy_ostateczne.Controllers
{
    public class TotolotekController : Controller
    {
        // GET: Totolotek
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClient(ClientViewModel user)
        {
            var User = new Client
            {
                FirstName = user.FirstName,
                Name = user.Name
            };
            //if (ModelState.IsValid)
            //{
            //    if (_usersService.IsValid(user.Email, User.Password))
            //    {
            //        FormsAuthentication.SetAuthCookie(user.Email, user.RememberMe);
            //        return RedirectToAction("Index", "Admin");
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", Resources.strings.uncorrectpass);
            //    }
            //}
            //return View(user);
            return View();
        }


        // GET: Totolotek/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Totolotek/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Totolotek/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Totolotek/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Totolotek/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Totolotek/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Totolotek/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
