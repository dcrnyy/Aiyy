using Common;
using System;
using System.Xml.Serialization;

namespace Model.WeChat.Msg
{
    /// <summary>
    /// 基础消息内容--基类
    /// </summary>
    [XmlRoot(ElementName = "xml")]
    public class BaseMessage
    {
        /// <summary>
        /// 初始化一些内容，如创建时间为整形，
        /// </summary>
        public BaseMessage()
        {
            this.CreateTime = DateTimeToUnixTimestamp(DateTime.Now);
        }

        /// <summary>
        /// 开发者微信号
        /// </summary>
        public string ToUserName { get; set; }

        /// <summary>
        /// 发送方帐号（一个OpenID）
        /// </summary>
        public string FromUserName { get; set; }

        /// <summary>
        /// 消息创建时间 （整型）
        /// </summary>
        public int CreateTime { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public string MsgType { get; set; }

        public virtual string ToXml()
        {
            CreateTime = DateTimeToUnixTimestamp(DateTime.Now); //重新更新           
            return XmlHelper.Serializer(this);
        }

        private int DateTimeToUnixTimestamp(DateTime dateTime)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, dateTime.Kind);
            return Convert.ToInt32((dateTime - start).TotalSeconds);
        }
    }
}
