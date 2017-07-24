using Abp.Modules;
using Abp.Web;
using AppService;
using System.Reflection;

namespace WcfService
{
    [DependsOn(typeof(AppServiceModule))]
    [DependsOn(typeof(AbpWebModule))]
    public class WcfServiceModule : AbpModule
    {
        public override void Initialize()
        {
        }
    }
}