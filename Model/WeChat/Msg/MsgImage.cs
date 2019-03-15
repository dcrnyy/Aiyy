using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Model.WeChat.Msg
{
    /// <summary>
    /// 图片消息
    /// </summary>
    [XmlRoot(ElementName = "xml")]
    public class MsgImage : BaseMessage
    {
        /// <summary>
        /// 图片链接（由系统生成）
        /// </summary>
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string MediaId { get; set; }

    }
}
