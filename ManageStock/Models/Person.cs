using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageStock.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

    }
}