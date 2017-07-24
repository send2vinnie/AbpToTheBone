using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppService
{
    public class Service2 : IService2
    {
        public string GetData()
        {
            return "<a prop='data' />";
        }
    }
}