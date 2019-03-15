using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Model.WeChat.Msg
{
    /// <summary>
    /// 客服消息
    /// </summary>
    public class MsgKF
    {
        public MsgKF(string openId,string msg)
        {
            touser = openId;
            msgtype = "text";
            text = new StrText();
            text.content = msg;
        }

        public string touser { get; set; }

        public string msgtype { get; set; }

        public StrText text { get; set; }
        public class StrText
        {
            public string content { get; set; }
        }
    }

   

    
}
