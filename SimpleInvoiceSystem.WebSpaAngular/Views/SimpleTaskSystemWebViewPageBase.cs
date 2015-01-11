using Abp.Web.Mvc.Views;

namespace SimpleInvoiceSystem.WebSpaAngular.Views
{
    public abstract class SimpleInvoiceSystemWebViewPageBase : SimpleInvoiceSystemWebViewPageBase<dynamic>
    {

    }

    public abstract class SimpleInvoiceSystemWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SimpleInvoiceSystemWebViewPageBase()
        {
            LocalizationSourceName = "SimpleInvoiceSystem";
        }
    }
}