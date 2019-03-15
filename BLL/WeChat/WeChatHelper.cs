using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.WeChat
{
    public class WeChatHelper
    {
        public static WeChatConfig  wechatConfig = new WeChatConfig();

        /// <summary>
        /// 微信接口校验
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="nonce"></param>
        /// <param name="signature"></param>
        /// <returns></returns>
        public static bool CheckSignature(string timestamp,string nonce,string signature)
        {
            string[] tmpArr = new string[] { wechatConfig.Token, timestamp, nonce };
            Array.Sort(tmpArr);
            string tmpStr = string.Join("", tmpArr);
            //sha1加密
            System.Security.Cryptography.SHA1 sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            byte[] secArr = sha1.ComputeHash(System.Text.Encoding.Default.GetBytes(tmpStr));
            tmpStr = BitConverter.ToString(secArr).Replace("-", "").ToLower();
            return (tmpStr == signature);
        }
    }

    public class WeChatConfig
    {
        public string AppID = "76197789648c5894";
        public string AppSecret = "f0c5e223b1e8707d0256f12d96258dbc";
        public string Token = "huiguorouaiyy";

        /// <summary>
        /// 开发者openID
        /// </summary>
        public string Developer = "oHAaY0lTHQHV5AxVCdLpai2U4AAM";

        /// <summary>
        /// 管理员openid
        /// </summary>
        public List<string> AdminOpenId = new List<string> { "oHAaY0lTHQHV5AxVCdLpai2U4AAM" };
    }
}
