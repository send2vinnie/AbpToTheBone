using Abp.Modules;
using Abp.Web;
using Abp.Web.Mvc;
using Abp.WebApi;
using AppService;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WcfClient = WebApi.ServiceReference1;

namespace WebApi
{
    [DependsOn(
        typeof(AppServiceModule),
        typeof(AbpWebApiModule),
        typeof(AbpWebMvcModule))]
    public class WebApiModule : AbpModule
    {
        public override void PreInitialize()
        {
            var container = IocManager.IocContainer;

            container.Register(
                Component.
                    For<Lazy<WcfClient.IService1>>().
                    UsingFactoryMethod(k => new Lazy<WcfClient.IService1>(() => new ServiceReference1.Service1Client())).
                    LifestyleTransient()
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}