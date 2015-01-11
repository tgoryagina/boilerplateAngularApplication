using System.Configuration;
using System.Reflection;
using Abp.Modules;
using Abp.NHibernate;
using Abp.NHibernate.Config;
using FluentNHibernate.Cfg.Db;

namespace SimpleInvoiceSystem
{
    [DependsOn(typeof(SimpleInvoiceSystemCoreModule), typeof(AbpNHibernateModule))]
    public class SimpleInvoiceSystemDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            var connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            Configuration.Modules.AbpNHibernate().FluentConfiguration
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connStr))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()));
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}