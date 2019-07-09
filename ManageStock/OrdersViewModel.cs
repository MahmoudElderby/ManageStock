using ManageStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ManageStock
{
    public class OrdersViewModel
    {
        public int id { get; set; }
        public string PersonName { get; set; }
        public string StockName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Commission { get; set; }


       public static void addOrders(List<Stock> stocks)
        {
            Random r = new Random();

            var _context = new MarketContext();
            var  broker = _context.Brokers.Include(b => b.Orders).Include(b => b.Persons).Where(b=>b.BrokerId==4).FirstOrDefault();

            for (int i =0; i<= 1;i++)
            {

                var order = new Order();
                order.StockId = r.Next(1, 28);
                order.Quantity = r.Next(1,100);
                var temp = stocks.Where(s => s.StockId == order.StockId).First();

                order.Price = temp.Price;
                order.Commission = (order.Quantity * order.Price);

                broker.Orders.Add(order);
            }
            _context.SaveChanges();

        }

        public static List<OrdersViewModel> GetOrders()
        {
            var _context = new MarketContext();

            var OrderList = new List<OrdersViewModel>();

            var Brokers = _context.Brokers.Include(b => b.Orders.Select(o => o.Stock)).Include(b => b.Persons.Select(p => p.Orders.Select(o => o.Stock))).ToList();

            foreach (var broker in Brokers)
            {

                foreach (var order in broker.Orders)
                {
                    var neworder = new OrdersViewModel();
                    neworder.PersonName = broker.Name;
                    neworder.Price = order.Price;
                    neworder.Quantity = order.Quantity;
                    neworder.StockName = order.Stock.Name;
                    neworder.Commission = order.Commission;

                    OrderList.Add(neworder);

                }

                foreach (var person in broker.Persons)
                {
                    foreach (var order in person.Orders)
                    {
                        var neworder = new OrdersViewModel();
                        neworder.PersonName = person.Name;
                        neworder.Price = order.Price;
                        neworder.Quantity = order.Quantity;
                        neworder.StockName = order.Stock.Name;
                        neworder.Commission = order.Commission;

                        OrderList.Add(neworder);

                    }

                }

            }
            return OrderList;
        }
    }



}