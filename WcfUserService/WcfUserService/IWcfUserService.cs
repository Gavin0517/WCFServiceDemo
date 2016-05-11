using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfUserService.model;

namespace WcfUserService
{
    [ServiceContract(Namespace = ServiceEnvironment.ServiceNamespace, Name = "user")]    
    public interface IWcfUserService
    {
        /// <summary>
        /// 根据code获取对象(GET请求处理)
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "search/{code}", ResponseFormat = ServiceEnvironment.WebResponseFormat, RequestFormat = ServiceEnvironment.WebRequestFormat, BodyStyle = ServiceEnvironment.WebBodyStyle)]
        UserInfo GetUserInfoSingle(string code);

        /// <summary>
        /// 注册新的用户(POST请求处理)
        /// </summary>
        /// <param name="user">注册用户信息</param>
        /// <returns>注册成功返回注册用户基本信息</returns>
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "register", ResponseFormat = ServiceEnvironment.WebResponseFormat, RequestFormat = ServiceEnvironment.WebRequestFormat, BodyStyle = ServiceEnvironment.WebBodyStyle)]
        UserInfo Register(UserInfo user);

        /// <summary> 
        /// 只能Get的常规方法 
        /// </summary> 
        /// <param name="person"></param> 
        /// <param name="welcome"></param> 
        /// <returns></returns> 
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "get", ResponseFormat = ServiceEnvironment.WebResponseFormat, RequestFormat = ServiceEnvironment.WebRequestFormat, BodyStyle = ServiceEnvironment.WebBodyStyle)]
        List<UserInfo> GETTest();
        
    }
}
