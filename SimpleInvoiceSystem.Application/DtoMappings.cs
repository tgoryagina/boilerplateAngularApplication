using AutoMapper;
using SimpleInvoiceSystem.Invoices.Dtos;
using SimpleInvoiceSystem.People.Dtos;
using SimpleInvoiceSystem.Products.Dtos;
using SimpleInvoiceSystem.Tasks.Dtos;
using SimpleInvoiceSystem.People;
using SimpleInvoiceSystem.Tasks;

namespace SimpleInvoiceSystem
{
    internal static class DtoMappings
    {
        public static void Map()
        {
            Mapper.CreateMap<Task, TaskDto>().ForMember(t => t.AssignedPersonId, opts => opts.MapFrom(d => d.AssignedPerson.Id));
            
            Mapper.CreateMap<Person, PersonDto>();

            Mapper.CreateMap<Invoice, InvoiceDto>().ForMember(t => t.ProductId, opts => opts.MapFrom(d => d.Product.Id));

            Mapper.CreateMap<Product, ProductDto>();
        }
    }
}
