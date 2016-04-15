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
    public interface IOAuthSvr
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Token", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        TokenResult Token(TokenRequest request);
    }
}