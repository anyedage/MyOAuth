using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyOAuth.AuthServer.Entities;

namespace MyOAuth.AuthServer.Svrs
{
    public class ManageSvr : IManageSvr
    {
        public ValidAndGetUserIdResult ValidAndGetUserId(string token, string scope)
        {
            return Bll.ValidAndGetUserId(token, scope);
        }
    }
}