using Abp.Application.Services.Dto;

namespace SimpleInvoiceSystem.Products.Dtos
{
    public class ProductDto : EntityDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}