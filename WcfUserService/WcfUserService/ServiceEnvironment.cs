using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace WcfUserService
{
    public class ServiceEnvironment
    {
        public const string ServiceNamespace = "Test";
        /// web请求格式
        /// </summary>
        public const WebMessageFormat WebRequestFormat = WebMessageFormat.Json;

        /// <summary>
        /// web相应格式
        /// </summary>
        public const WebMessageFormat WebResponseFormat = WebMessageFormat.Json;


        /// <summary>
        /// 请求内容封装方式
        /// </summary>
        public const WebMessageBodyStyle WebBodyStyle = WebMessageBodyStyle.Bare;
    }
}