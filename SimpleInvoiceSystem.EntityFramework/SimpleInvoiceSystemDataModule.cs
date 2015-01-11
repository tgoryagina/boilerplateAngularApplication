using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using SimpleInvoiceSystem;

namespace SimpleInvoiceSystem
{
    [DependsOn(typeof(SimpleInvoiceSystemCoreModule), typeof(AbpEntityFrameworkModule))]
    public class SimpleInvoiceSystemDataModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
