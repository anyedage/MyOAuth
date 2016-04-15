using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Web;
using System.ServiceModel;

namespace MyOAuth.ResourceServer.Svrs
{
    [ServiceContract]
    public interface IResourceSvr
    {
        [OperationContract]
        [WebGet(UriTemplate = "GetUser/{token}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        User GetUser(string token);

        [OperationContract]
        [WebGet(UriTemplate = "GetFriend/{token}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string GetFriend(string token);

        [OperationContract]
        [WebGet(UriTemplate = "GetEnemy/{token}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string GetEnemy(string token);

        [OperationContract]
        [WebGet(UriTemplate = "GetUserIdByLogin/{loginName}/{pwd}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string GetUserIdByLogin(string loginName, string pwd);
    }
}
