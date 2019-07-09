using ManageStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManageStock.Controllers
{
    public class MarketController : Controller
    {
        // GET: Market
        public ActionResult Index()
        {
            var _context = new MarketContext();
            var StockList = _context.Stocks.ToList();
            Random r = new Random();
            foreach (var item in StockList)
            {
                
               item.Price= r.Next(0, 100);
            }

            return View(StockList);
        }
    }
}