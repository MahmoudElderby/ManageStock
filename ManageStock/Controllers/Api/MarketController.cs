using ManageStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManageStock.Controllers.Api
{
    public class MarketController : ApiController
    {
        private MarketContext _context; 
        public MarketController()
        {
            _context = new MarketContext();
        }

       [HttpGet]
        public IHttpActionResult GetStock()
        {
            var _context = new MarketContext();
            var StockList = _context.Stocks.ToList();
            return Ok(StockList);
        }

    }
}
