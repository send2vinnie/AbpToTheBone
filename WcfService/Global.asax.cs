using Abp.Web;
using Castle.Facilities.WcfIntegration;
using System;

namespace WcfService
{
    public class Global : AbpWebApplication<WcfServiceModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<WcfFacility>(f => f.CloseTimeout = TimeSpan.Zero);
            base.Application_Start(sender, e);
        }
    }
}