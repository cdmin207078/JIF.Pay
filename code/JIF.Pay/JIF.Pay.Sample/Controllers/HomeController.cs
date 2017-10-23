using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Util;
using JIF.Pay.Sample.App_Start;
using JIF.Pay.Sample.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            DefaultAopClient client = new DefaultAopClient(config.gatewayUrl, config.app_id, config.private_key, "json", "1.0", config.sign_type, config.alipay_public_key, config.charset, false);

            // 组装业务参数model
            AlipayTradeWapPayModel model = new AlipayTradeWapPayModel();
            model.Body = order.Remark.Trim();                                      // 商品描述
            model.Subject = order.Subject.Trim();                                // 订单名称
            model.TotalAmount = order.Amount.ToString("0.##");                        // 付款金额
            model.OutTradeNo = order.OrderNo;                        // 外部订单号，商户网站订单系统中唯一的订单号
            model.ProductCode = "QUICK_WAP_PAY";
            //model.QuitUrl = quit_url;                               // 支付中途退出返回商户网站地址

            AlipayTradeWapPayRequest request = new AlipayTradeWapPayRequest();
            // 设置支付完成同步回调地址
            request.SetReturnUrl("");
            // 设置支付完成异步通知接收地址
            request.SetNotifyUrl("http://192.168.0.107:30001/home/AlipayCallback");
            // 将业务model载入到request
            request.SetBizModel(model);

            AlipayTradeWapPayResponse response = null;
            try
            {
                response = client.pageExecute(request, null, "post");
                return AjaxOk("支付宝 - 成功", response.Body);
            }
            catch (Exception exp)
            {
                return AjaxFail("支付宝 - 失败", JsonConvert.SerializeObject(exp));
            }
        }


        public JsonResult AlipayQuery(string orderNo, string aliBusinessOrderNo)
        {
            DefaultAopClient client = new DefaultAopClient(config.gatewayUrl, config.app_id, config.private_key, "json", "1.0", config.sign_type, config.alipay_public_key, config.charset, false);

            AlipayTradeQueryModel model = new AlipayTradeQueryModel();
            model.OutTradeNo = orderNo;                         // 商户订单号，和交易号不能同时为空
            model.TradeNo = aliBusinessOrderNo;                 // 支付宝交易号，和商户订单号不能同时为空

            AlipayTradeQueryRequest request = new AlipayTradeQueryRequest();
            request.SetBizModel(model);

            AlipayTradeQueryResponse response = null;
            try
            {
                response = client.Execute(request);
                return AjaxOk(response.Body);
            }
            catch (Exception exp)
            {
                return AjaxFail(JsonConvert.SerializeObject(exp));
            }
        }


        public JsonResult AlipayCallback()
        {
            /* 实际验证过程建议商户添加以下校验。
              1、商户需要验证该通知数据中的out_trade_no是否为商户系统中创建的订单号，
              2、判断total_amount是否确实为该订单的实际金额（即商户订单创建时的金额），
              3、校验通知中的seller_id（或者seller_email) 是否为out_trade_no这笔单据的对应的操作方（有的时候，一个商户可能有多个seller_id/seller_email）
              4、验证app_id是否为该商户本身。
              */
            Dictionary<string, string> sArray = GetRequestPost();
            if (sArray.Count != 0)
            {
                bool flag = AlipaySignature.RSACheckV1(sArray, config.alipay_public_key, config.charset, config.sign_type, false);
                if (flag)
                {
                    //交易状态
                    //判断该笔订单是否在商户网站中已经做过处理
                    //如果没有做过处理，根据订单号（out_trade_no）在商户网站的订单系统中查到该笔订单的详细，并执行商户的业务程序
                    //请务必判断请求时的total_amount与通知时获取的total_fee为一致的
                    //如果有做过处理，不执行商户的业务程序

                    //注意：
                    //退款日期超过可退款期限后（如三个月可退款），支付宝系统发送该交易状态通知
                    string trade_status = Request.Form["trade_status"];

                    return AjaxOk("支付宝 - 回调成功");
                }
                else
                {
                    return AjaxFail("支付宝 - 回调失败");
                }
            }

            return AjaxFail("无信息");
        }

        public Dictionary<string, string> GetRequestPost()
        {
            int i = 0;
            Dictionary<string, string> sArray = new Dictionary<string, string>();
            NameValueCollection coll;
            //coll = Request.Form;
            coll = Request.Form;
            String[] requestItem = coll.AllKeys;
            for (i = 0; i < requestItem.Length; i++)
            {
                sArray.Add(requestItem[i], Request.Form[requestItem[i]]);
            }
            return sArray;
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