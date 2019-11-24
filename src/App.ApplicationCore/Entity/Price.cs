using System;
using System.Collections.Generic;
using System.Text;

namespace App.ApplicationCore.Entity
{
    public class Price
    {
        public int PriceId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public decimal Value { get; set; }
    }
}
