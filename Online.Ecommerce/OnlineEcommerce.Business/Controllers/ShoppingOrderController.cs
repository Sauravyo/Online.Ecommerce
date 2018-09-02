using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineEcommerce.Business.Controllers
{
    public class ShoppingOrderController : Controller
    {
        // GET: ShoppingOrder
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShoppingOrder/AddOrder/5
        public ActionResult PlaceOrder()
        {
           
            return View();
        }

        // POST: ShoppingOrder/Create
        [HttpPost]
        public ActionResult RemoveOrder()
        {
            return View();
        }

        // POST: ShoppingOrder/Create
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

        // GET: ShoppingOrder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShoppingOrder/Edit/5
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

        // GET: ShoppingOrder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShoppingOrder/Delete/5
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
