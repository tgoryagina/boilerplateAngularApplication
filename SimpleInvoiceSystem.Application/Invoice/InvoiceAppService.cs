using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using SimpleInvoiceSystem.Invoices.Dtos;

namespace SimpleInvoiceSystem.Invoices
{
    public class InvoiceAppService : ApplicationService, IInvoiceAppService
    {
        //These members set in constructor using constructor injection.
        
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IRepository<Product> _productRepository;
        

        public InvoiceAppService(IInvoiceRepository invoiceRepository, IRepository<Product> productRepository)
        {
            _invoiceRepository = invoiceRepository;
            _productRepository = productRepository;
        }

        public GetInvoiceOutput GetInvoices(GetInvoiceInput input)
        {
            var invoices = _invoiceRepository.GetAllWithProduct(input.ProductId);

            //Used AutoMapper to automatically convert List<Task> to List<TaskDto>.
            return new GetInvoiceOutput
                   {
                       Invoice = Mapper.Map<List<InvoiceDto>>(invoices)
                   };
        }

        public void UpdateInvoice(UpdateInvoiceInput input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            Logger.Info("Updating a invoice for input: " + input);

            //Retrieving a task entity with given id using standard Get method of repositories.
            var invoice = _invoiceRepository.Get(input.InvoiceId);

            if (input.ProductId.HasValue)
            {
                invoice.Product = _productRepository.Load(input.ProductId.Value);

                if (invoice.Quantity.HasValue)
                invoice.Price = invoice.Product.Price*invoice.Quantity;
            }
        }

        public void CreateInvoice(CreateInvoiceInput input)
        {
            Logger.Info("Creating a invoice for input: " + input);

            var invoice = new Invoice{ Quantity = input.Count };

            if (input.ProductId.HasValue)
            {
                invoice.Product = _productRepository.Load(input.ProductId.Value);

                if (invoice.Quantity.HasValue)
                    invoice.Price = invoice.Product.Price * invoice.Quantity;
            }

            _invoiceRepository.Insert(invoice);
        }
    }
}