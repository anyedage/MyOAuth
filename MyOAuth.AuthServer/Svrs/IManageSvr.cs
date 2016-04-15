using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyOAuth.AuthServer.Entities;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace MyOAuth.AuthServer.Svrs
{
    [ServiceContract]
    public interface IManageSvr
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "ValidAndGetUserId", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ValidAndGetUserIdResult ValidAndGetUserId(string token, string scope);
    }
}