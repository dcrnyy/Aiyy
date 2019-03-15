using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class WeChatController : Controller
    {
        [HttpGet]
        [ActionName("Index")]
        [AllowAnonymous]
        public ActionResult Get(string echoStr,string timestamp = "", string nonce = "", string signature = "")
        {
            if (string.IsNullOrWhiteSpace(echoStr) == false && BLL.WeChat.WeChatHelper.CheckSignature(timestamp, nonce, signature))
                return Content(echoStr);
            return Content("api");
        }

        [HttpPost]
        [ActionName("Index")]
        [AllowAnonymous]
        public string Post(WeChatRequest wx)
        {
            //获取xml
            Stream temp = Request.InputStream;
            byte[] requestByte = new byte[temp.Length];
            temp.Read(requestByte, 0, (int)temp.Length);
            string xml = Encoding.UTF8.GetString(requestByte);  //处理发送过来的信息
            //xml = db.Execute(xml);
            return xml;
        }


    }

    public class WeChatRequest
    {
        public string Token { get; set; }
        public string echoStr { get; set; }
        public string signature { get; set; }
        public string timestamp { get; set; }
        public string nonce { get; set; }
    }

}