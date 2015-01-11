using System;
using Abp.Application.Services.Dto;

namespace SimpleInvoiceSystem.Invoices.Dtos
{
    public class InvoiceDto : EntityDto<long>
    {
        public int? ProductId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public DateTime CreationTime { get; set; }
    }
}