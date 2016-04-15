using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri("http://we.fs@www.baidu.com/a/b/c.aspx?x=1#sf");
            var scheme = uri.Scheme;
            var authority = uri.Authority;
            var query = uri.Query;
            var rragment = uri.Fragment;
        }
    }
}
