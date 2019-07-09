using ManageStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ManageStock.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View(OrdersViewModel.GetOrders());
        }

        public ActionResult Add()
        {
            //OrdersViewModel.addOrders();

            return RedirectToAction("Index");
        }
    }
}