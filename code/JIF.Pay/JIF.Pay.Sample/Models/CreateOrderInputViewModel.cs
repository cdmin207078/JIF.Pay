﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JIF.Pay.Sample.Models
{
    public class CreateOrderInputViewModel
    {
        public string OrderNo { get; set; }

        public string Subject { get; set; }

        public string Remark { get; set; }

        public decimal Amount { get; set; }
    }
}