using Abp.Application.Services.Dto;

namespace SimpleInvoiceSystem.Invoices.Dtos
{
    public class GetInvoiceInput : IInputDto
    {
        public int? ProductId { get; set; }
    }
}