using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JIF.Pay.Sample.App_Start
{
    public class config
    {
        public config()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //

        }
        // 应用ID,您的APPID
        public static string app_id = "2016081600259106";

        // 支付宝网关
        //public static string gatewayUrl = "https://openapi.alipay.com/gateway.do";

        public static string gatewayUrl = "https://openapi.alipaydev.com/gateway.do";

        // 商户私钥，您的原始格式RSA私钥
        public static string private_key = "MIIEpAIBAAKCAQEA4g4Rv5fGxM8Hrs+Ynlxpow44qtGuzuCKUmc8lnVGo1vsOnPzdJmq64UGm8YUGu2TGuwLbBjIX3zBMEy5PODqVWFioNySfu5sCqaODSu7Nhp0/VnoHKM5WLyQ2bgVq9/xbbcuN6hXO3NKZwoT+xiOFbnaInNRKa3AlTcjbuGMRRVsSkqyJgWMReXalHXQqQCDZ8rYU6Ow38W9qB064t0e3qytmgltpdxa1fMp+1j8oVqGQxuu7g0kyXaMfs0I2J8bqSEjkkGfAZK2GjjL4iq5pHjSYLPaUHesjimNbEVaeJJNSVlQXsPcKiHNZJ7PYwKFt+FqCOVs268ce72toL2bGQIDAQABAoIBAGpQP5yh3wOUcoKOc7KWt7/N4mzD7Liy9ZrHnsEMKsqNYs4i1i7SToYxq+f7Al2fuf2BYeXWyfXOkHUMwFmXVd4NzPrmgadcrkdcCZa8KHHLg5XbgMRnJ4NKO72JS/fnfH4jFoNqkowNLsLDBJ6k773cCHEHVvaJFveWVP3C6dta05trwY8DWERy+137WKM8bxx9VVyWAEzq+TAZHkDk8t/yMKWOEnX16IjtCc4DwvcjpTL+VF+rNVO8S+pYsK0NNwZkIjdfn/vp8gvSGs6nDZwXsG4jpXKgARG7uTqlBJagD1DCJGJbJ307a3UWvFQ9hCXhIHmNXOMlSBKnHANpZbkCgYEA9iB/cnTxknvZnEFz4PcszpeZZPIrAIKjP+5krMyyn/z3RD7k7UYQKm4Pn+GXXe38VpB7E3nSTEGzW0QLbNU6uoDXuTfnj6kMgIxcXXT43SyLzJ9Uy1G8J82bvUsK4y2fell6cuExjeTYw9ymBwkhV4a2UGnuhCufoRCcTO/hSHcCgYEA6x9zRB7fY8F7hobHm691kOQ5E521x1i0mucq313Z7oUsdhljZHuzrtiAdlt93rsFT9ozLQVNOftyuqJ0+NcsVOa+p4mHoXKnnYLL6g9KgrC5+JE2wzHIwq6bYGoRW97Am50mVcU0RO6ITgQkKP0fSaOpMfOAdxgQUbUf9c7drO8CgYEAxyBXvCQ85YRp9G9H7zRK/gHMyszaWZlXtnuK2/rocWPaMU6pLAZJQeq1nWaIbigCxY4y5PjkWWm2UBpnG/APiaB/54wBPktIoB/vAnWGenp1yGEH208PaSyB2c4CyvW4VuZZmOP0kZYagavcb0jFvuhwS/LIVApvJYIo0l4o59UCgYEA2As3A+IGTAhN86fGpCRON8utMnwYusqkcS12dHYtOQD/gKkFbiBIU6G2MIsTFmTslZoeqgCUHHIS0rFSIBC/OGgpyZISoWPT5mR38GMKiRnQWDk+g48sNM7yEF6GAs+kVZjJz8f7plczwdQGUe98H1MVtcNUSJpA7IMskdX6VNsCgYBKij5IMI12uIqgRmo/RCc1yyzh6Ey8l2DsDEw8Ew7wcID/ZgAiCqHkerf5vPMMBpJ+3h8R3azqFBPJsX84/M2SlpCkvSapiDPeNs6k9FdTkBtn+1SVhkvsSldtL79cRLSRnqFI0n+H6PRb4kGlXvk95ue8fp3knfVucJ99gwZHjg==";

        // 支付宝公钥,查看地址：https://openhome.alipay.com/platform/keyManage.htm 对应APPID下的支付宝公钥。
        public static string alipay_public_key = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEApMuVyYUeQNrRRnUlGLeCzlg8Bje2zXzQG6RD9Srrnwpnqc/zANrcrUKX3KA/u5XJB4Tzykd9gNz+8FyVta6zuDig0GwnXD+m71MpEBBY2BP12iWo9U4NePe/N5MjLArlgWaHUUjLFIovK/BSevxhd/6zSgcwjXdDIpalT62BvzB+9MfWAL277+9132wfTa6piRvWPVykLMrAkwSNuP8ACelFRe9RhdGYtPHIy5JeJMMzSFghwL7WPmLOHIJgK/bxRbXX0qN4GUW3C9SEUdrlN+LyP1kd7V3aa2k0jIZkpjEJj3ACYhC+Z7SKcK6OXolRCAiChXYgdZUYLL0e/p9khQIDAQAB";

        // 签名方式
        public static string sign_type = "RSA2";

        // 编码格式
        public static string charset = "UTF-8";
    }
}