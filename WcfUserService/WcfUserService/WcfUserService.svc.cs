using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using WcfUserService.model;

namespace WcfUserService
{
    //要以IIS管道运行WCF服务 只需要加上这个特性就可以 运行网站的同时 运行WCF服务 AJAX也可以请求到了
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)] //对象在每次调用前创建，在调用后回收
    //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class WcfUserService : IWcfUserService
    {
        public UserInfo GetUserInfoSingle(string code)
        {
            // var request= WebOperationContext.Current.IncomingRequest;
            //测试数据
            IList<UserInfo> list = new List<UserInfo>()
             {
                 new UserInfo(){ Id="1", Code="000001", Name="乔峰", Description="乔大爷啊"},
                 new UserInfo(){ Id="2", Code="600000", Name="段誉", Description="你爹真是风流倜傥啊"},
                 new UserInfo(){ Id="3", Code="000002", Name="慕容复", Description="妹子被楼上的抢咯，太失败了"},
                 new UserInfo(){ Id="4", Code="000008", Name="庄聚贤", Description="无所事事的帅哥庄聚贤"}
             };
            return list.Where(e => e.Code == code).FirstOrDefault();
        }

        public UserInfo Register(UserInfo user)
        {
            if (user == null)
                return null;
            user.Description = "POST搞定了！";
            return user;
        }

        //public List<UserInfo> GETTest(string person, string welcome)
        //{            
        //    List<UserInfo> userinfos= new List<UserInfo>();
        //    userinfos.Add(new UserInfo() { Id = "4", Code = "000008", Name = "庄聚贤", Description = "无所事事的帅哥庄聚贤" });
        //    return userinfos;
        //} 
        public List<UserInfo> GETTest()
        {
            List<UserInfo> userinfos = new List<UserInfo>();
            userinfos.Add(new UserInfo() { Id = "4", Code ="", Name = "", Description = "传参数测试" });
            return userinfos;
        } 
    }
}
