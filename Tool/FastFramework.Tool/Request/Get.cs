using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using FastFramework.Core;

namespace FastFramework.Tool.Request
{
    public class Get
    {
        /// <summary>
        /// GET方式请求URL，并返回T类型
        /// </summary>
        /// <typeparam name="T">接收JSON的数据类型</typeparam>
        /// <param name="url"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static T GetJson<T>(string url, Encoding encoding = null)
        {
            string returnText = RequestUtility.HttpGet(url, encoding);

            var result = (returnText ?? "").To<T>();

            return result;
        }

        public static T GetJson<T>(string url, Dictionary<string, string> query, Encoding encoding = null)
        {

            var returnText = GetString(url, query, encoding);
            var result = (returnText ?? "").To<T>();

            return result;
        }


        public static string GetString(string url, Dictionary<string, string> query, Encoding encoding = null)
        {
            url += "?" + query.GetQueryString();

            return RequestUtility.HttpGet(url, encoding);

        }
        /// <summary>
        /// 从Url下载
        /// </summary>
        /// <param name="url"></param>
        /// <param name="stream"></param>
        public static void Download(string url, Stream stream)
        {
            WebClient wc = new WebClient();
            var data = wc.DownloadData(url);
            foreach (var b in data)
            {
                stream.WriteByte(b);
            }
        }

    }
}
