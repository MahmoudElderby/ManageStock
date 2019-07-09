using ManageStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManageStock.Controllers.Api
{
    public class OrderController : ApiController
    {
        private  MarketContext _context;
        public OrderController()
        {
            _context = new MarketContext();
        }

        [HttpPost]
        public IHttpActionResult CreateRandomOrders(List<Stock> stocks)
        {
            OrdersViewModel.addOrders(stocks);

            return Ok(OrdersViewModel.GetOrders());
        }
        [HttpGet]
        public IHttpActionResult GerOrders()
        {
            return Ok(OrdersViewModel.GetOrders());
        }

    }
}
