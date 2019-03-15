using System.Xml.Serialization;

namespace Model.WeChat.Msg
{
    /// <summary>
    /// 文本消息
    /// </summary>
    [XmlRoot(ElementName = "xml")]
    public class MsgText : BaseMessage
    {
        public MsgText()
        { }

        public MsgText(BaseMessage obj)
        {
            this.FromUserName = obj.ToUserName;
            this.ToUserName = obj.FromUserName;
            this.MsgType = "text";
        }

        /// <summary>
        /// 文本消息内容
        /// </summary>
        public string Content { get; set; }

    }
}
