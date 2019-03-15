using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Common
{
    public static class XmlHelper
    {
        #region 反序列化
        /// <summary>
        /// 反序列化--xml2obj
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="xml">XML字符串</param>
        /// <returns></returns>
        public static T Deserialize<T>(string xml) where T : class
        {
            try
            {
                using (StringReader sr = new StringReader(xml))
                {
                    XmlSerializer xmldes = new XmlSerializer(typeof(T));
                    return (T)xmldes.Deserialize(sr);
                }
            }
            catch (Exception e)
            {

                return null;
            }
        }
        ///// <summary>
        ///// 反序列化
        ///// </summary>
        ///// <param name="type"></param>
        ///// <param name="xml"></param>
        ///// <returns></returns>
        //public static object Deserialize(Type type, Stream stream)
        //{
        //    XmlSerializer xmldes = new XmlSerializer(type);
        //    return xmldes.Deserialize(stream);
        //}
        #endregion

        #region 序列化
        /// <summary>
        /// 序列化--obj2xml
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        public static string Serializer(object obj)
        {
            MemoryStream Stream = new MemoryStream();
            //去除开头的<?xml version="1.0" encoding="utf-8"?>
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            using (XmlWriter writer = XmlWriter.Create(Stream, settings))
            {
                //去除默认命名空间xmlns:xsd和xmlns:xsi
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                try
                {
                    //序列化对象
                    XmlSerializer xml = new XmlSerializer(obj.GetType());
                    xml.Serialize(writer, obj, ns);
                }
                catch (Exception er)
                {

                }
            }
            // return Encoding.Default.GetString(Stream.ToArray());
            Stream.Position = 0;
            StreamReader sr = new StreamReader(Stream);
            string str = sr.ReadToEnd();

            sr.Dispose();
            Stream.Dispose();

            return str;
        }

        #endregion
    }
}
