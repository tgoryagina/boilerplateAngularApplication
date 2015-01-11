using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace SimpleInvoiceSystem.Invoices.Dtos
{
    public class CreateInvoiceInput : IInputDto
    {
        public int? ProductId { get; set; }

        [Required]
        public int Count { get; set; }

        public override string ToString()
        {
            return string.Format("[CreateInvoiceInput > ProductId = {0}, Count = {1}]", ProductId, Count);
        }
    }
}