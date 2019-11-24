using System;
using System.Collections.Generic;
using System.Text;

namespace App.ApplicationCore.Entity
{
    public class OrderClient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public decimal OrderId { get; set; }
        public Order Order { get; set; }


    }
}
