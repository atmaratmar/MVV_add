using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVD_add.Models;

namespace MVD_add.Controllers
{
    public class AddNumbersController : Controller
    {
        // GET: AddNumbers
        public ActionResult Index1(int a,int b)
        {
            hello g = new hello();
            g.helloo = a + b;
            g.MyProperty = a * b;
            return View(g);
        }
       

        // GET: AddNumbers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddNumbers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddNumbers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index1));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddNumbers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddNumbers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index1));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddNumbers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddNumbers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index1));
            }
            catch
            {
                return View();
            }
        }
    }
}