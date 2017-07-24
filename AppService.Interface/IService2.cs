using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppService
{
    public interface IService2 : IApplicationService
    {
        string GetData();
    }
}