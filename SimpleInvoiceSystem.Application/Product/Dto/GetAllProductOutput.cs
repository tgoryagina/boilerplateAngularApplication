using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace SimpleInvoiceSystem.Products.Dtos
{
    public class GetAllProductOutput : IOutputDto
    {
        public List<ProductDto> Product { get; set; }
    }
}