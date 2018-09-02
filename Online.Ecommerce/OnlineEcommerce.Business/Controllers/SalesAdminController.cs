using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineEcommerce.BusinessLayer.Contracts;
using OnlineEcommerce.BusinessLayer;
using Online.Ecommerce.Entity;
using System.Net;
using OnlineEcommerce.Business.Models;

namespace OnlineEcommerce.Business.Controllers
{
    public class SalesAdminController : Controller
    {
        private readonly IItemService _itemService;
        private readonly ICustomerService _customerService;

        //private IItemService _itemServices = new ItemService();
        //Construtor Based Dependency Injection
        public SalesAdminController( IItemService itemService, ICustomerService customerService)
        {
            _itemService = itemService;
            _customerService = customerService;
        }


        #region ItemCRUDOPeration
        // GET: SalesAdmin/Details/5
        public ActionResult Details(int id)
        {
            Item item = _itemService.Detail(id);
            return View(item);
        }

        // GET: SalesAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesAdmin/Create
        [HttpPost]
        public ActionResult Create(Item item)
        {
            _itemService.Create(item);
            return View(item);

        }

        // GET: SalesAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            var item = _itemService.Edit(id);
            return View(item);
        }

        // POST: SalesAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(Item item)
        {

            // TODO: Add update logic here
            _itemService.Edit(item);
            return View();

        }

        // GET: SalesAdmin/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: SalesAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _itemService.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region SalesOrderOPeration

        public ActionResult SelectOrderItems()
        {
            var customerList = _customerService.CustomerList();
            var itemList = _itemService.ItemList();
            var salevm = new SaleOrderVM
            {
                CustomerVm = customerList,
                ItemVm=itemList
            };
            return View(salevm);
        }

        public ActionResult AddToSalesOrder()
        {
            var customerList = _customerService.CustomerList();
            var itemList = _itemService.ItemList();
            var salevm = new SaleOrderVM
            {
                CustomerVm = customerList,
                ItemVm = itemList
            };
            return View(salevm);
        }

        #endregion
    }
}
