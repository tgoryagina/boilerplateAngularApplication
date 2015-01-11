using Abp.Application.Services.Dto;

namespace SimpleInvoiceSystem.People.Dtos
{
    public class PersonDto : EntityDto
    {
        public string Name { get; set; }
    }
}