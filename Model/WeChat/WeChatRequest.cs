using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.WeChat
{
    public class WeChatRequest
    {
        public string Token { get; set; }
        public string echoStr { get; set; }
        public string signature { get; set; }
        public string timestamp { get; set; }
        public string nonce { get; set; }
    }
}
