using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageStock.Models
{
    public class Broker
    {
        public int BrokerId { get; set; }
        public string Name { get; set; }        
        public List<Order> Orders { get; set; } //List of his Orders made manually
        public List<Person> Persons { get; set; } //List of his clients 

    }
}