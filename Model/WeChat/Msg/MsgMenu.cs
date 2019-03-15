using System.Xml.Serialization;

namespace Model.WeChat.Msg
{

    [XmlRoot(ElementName = "xml")]
    public class MsgMenu : BaseMessage
    {
        /// <summary>
        /// 事件类型，VIEW
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// 事件类型
        /// 点击菜单拉取消息=CLICK
        /// 点击菜单跳转链接=VIEW
        /// </summary>
        public string EventKey { get; set; }

        /// <summary>
        /// 指菜单ID，如果是个性化菜单，则可以通过这个字段，知道是哪个规则的菜单被点击了。
        /// </summary>
        public string MenuID { get; set; }

    }
}
