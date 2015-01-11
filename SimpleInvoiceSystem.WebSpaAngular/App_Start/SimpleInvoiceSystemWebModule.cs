using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Localization;
using Abp.Localization.Sources.Xml;
using Abp.Modules;
using SimpleInvoiceSystem.Data;

namespace SimpleInvoiceSystem.WebSpaAngular
{
    [DependsOn(typeof(SimpleInvoiceSystemDataModule), typeof(SimpleInvoiceSystemWebApiModule))]
    public class SimpleInvoiceSystemWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            Configuration.Localization.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flag-tr"));

            //Add a localization source
            Configuration.Localization.Sources.Add(
                new XmlLocalizationSource(
                    "SimpleInvoiceSystem",
                    HttpContext.Current.Server.MapPath("~/Localization/SimpleInvoiceSystem")
                    )
                );

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<SimpleInvoiceSystemNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}