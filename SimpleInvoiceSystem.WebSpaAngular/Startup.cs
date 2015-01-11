using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleInvoiceSystem.WebSpaAngular.Startup))]
namespace SimpleInvoiceSystem.WebSpaAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}