﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime? OrderDate { get; set; }
        public virtual User User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
