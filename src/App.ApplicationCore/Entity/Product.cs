using System;
using System.Collections.Generic;
using System.Text;

namespace App.ApplicationCore.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int Status { get; set; }
        public int PriceId { get; set; }
        public Price Price { get; set; }

    }
}
