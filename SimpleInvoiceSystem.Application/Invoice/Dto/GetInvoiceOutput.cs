using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace SimpleInvoiceSystem.Invoices.Dtos
{
    public class GetInvoiceOutput : IOutputDto
    {
        public List<InvoiceDto> Invoice { get; set; } 
    }
}