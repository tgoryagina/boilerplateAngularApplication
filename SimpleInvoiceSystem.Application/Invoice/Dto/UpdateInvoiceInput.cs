using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;

namespace SimpleInvoiceSystem.Invoices.Dtos
{
    public class UpdateInvoiceInput : IInputDto, ICustomValidate
    {
        [Range(1, long.MaxValue)] //Data annotation attributes work as expected.
        public long InvoiceId { get; set; }

        public int? ProductId { get; set; }
        
        //Custom validation method. It's valled by ABP after data annotation validations.
        public void AddValidationErrors(List<ValidationResult> results)
        {
            if (ProductId == null)
            {
                results.Add(new ValidationResult("ProductId can not be null in order to update a Invoice!", new[] { "ProductId"}));
            }
        }

        public override string ToString()
        {
            return string.Format("[UpdateInvoiceInput > InvoiceId = {0}, ProductId = {1}]", InvoiceId, ProductId);
        }
    }
}