﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Application.DataContract.Response.Order
{
    public sealed class OrderItemResponse
    {
        public string ProductId { get; set; }
        public decimal SellValue { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
