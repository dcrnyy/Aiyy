using System.Xml.Serialization;

namespace Model.WeChat.Msg
{
    /// <summary>
    /// 事件消息类
    /// </summary>
    [XmlRoot(ElementName = "xml")]
    public class MsgEvent : BaseMessage
    {
        /// <summary>
        /// 事件类型：
        /// subscribe(订阅)
        /// unsubscribe(取消订阅)
        /// click=点击菜单按钮
        /// view=点击菜单跳转链接：EventKey=设置的跳转URL
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// 事件KEY值
        /// </summary>
        public string EventKey { get; set; }

        /// <summary>
        /// 指菜单ID，如果是个性化菜单，则可以通过这个字段，知道是哪个规则的菜单被点击了。
        /// </summary>
        public string MenuID { get; set; }
    }
}
