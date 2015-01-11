using Abp.Application.Services;
using SimpleInvoiceSystem.Invoices.Dtos;

namespace SimpleInvoiceSystem.Invoices
{
    public interface IInvoiceAppService : IApplicationService
    {
        GetInvoiceOutput GetInvoices(GetInvoiceInput input);

        void UpdateInvoice(UpdateInvoiceInput input);

        void CreateInvoice(CreateInvoiceInput input);
    }
}
