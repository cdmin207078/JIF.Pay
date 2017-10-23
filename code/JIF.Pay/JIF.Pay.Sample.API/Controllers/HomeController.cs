using JIF.Pay.Sample.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JIF.Pay.Sample.API.Controllers
{
    public class HomeController : BaseController
    {

        [HttpGet]
        public IHttpActionResult Welcome(string name)
        {
            return AjaxOk("Hello, " + name);
        }

        [HttpPost]
        public IHttpActionResult Pay(PaymentViewModel order)
        {
            return AjaxOk(new { Time = DateTime.Now, Order = order });
        }
    }
}
