using System;
using System.Collections.Generic;
using System.Text;

namespace App.ApplicationCore.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int Status { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }


    }
}
