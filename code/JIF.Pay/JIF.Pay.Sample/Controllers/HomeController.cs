using JIF.Pay.Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JIF.Pay.Sample.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        #region 支付宝支付

        [HttpPost]
        public JsonResult Alipay(CreateOrderInputViewModel order)
        {
            return AjaxOk("支付宝成功支付");
        }

        #endregion 

        #region 微信支付

        [HttpPost]
        public JsonResult Wechat(CreateOrderInputViewModel order)
        {
            return AjaxOk("微信成功支付");
        }

        #endregion
    }
}