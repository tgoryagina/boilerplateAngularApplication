using Abp.Web.Mvc.Controllers;

namespace SimpleInvoiceSystem.WebSpaAngular.Controllers
{
    public abstract class SimpleInvoiceSystemControllerBase : AbpController
    {
        protected SimpleInvoiceSystemControllerBase()
        {
            LocalizationSourceName = "SimpleInvoiceSystem";
        }
    }
}