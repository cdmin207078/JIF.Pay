using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JIF.Pay.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var link = "https://qr.alipay.com/bax04276ca83ytuno3x10065";

            var uri = new Uri(link);
        }
    }
}
