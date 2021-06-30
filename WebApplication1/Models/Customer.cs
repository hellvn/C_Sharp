using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        public Customer(string name, string telephone, string address)
        {
            Name = name;
            Telephone = telephone;
            Address = address;
        }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
    }
}