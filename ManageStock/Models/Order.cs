using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageStock.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int StockId { get; set; } //Stock.Id
        public Stock Stock { get; set; }
        public int Price { get; set; } //Stock.Price
        public double Quantity { get; set; } //How many items of this stock
        public double Commission { get; set; } //Company commission. to be calculate
    }
}