using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOAuth.AuthServer.Entities
{
    public enum ScopeEnum { getuser = 1, getfriend, getenemy }

    public static class ScopeExtend
    {
        public static string Description(this ScopeEnum scope)
        {
            var result = "";
            switch (scope)
            {
                case ScopeEnum.getuser:
                    result = "权限【获取用户信息】";
                    break;
                case ScopeEnum.getfriend:
                    result = "权限【获取用户'好友'信息】";
                    break;
                case ScopeEnum.getenemy:
                    result = "权限【获取用户'敌人'信息】";
                    break;
                default:
                    throw new Exception("scope类型错误");
            }
            return result;
        }
    }
}