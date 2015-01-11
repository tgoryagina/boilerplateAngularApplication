using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using AutoMapper;
using SimpleInvoiceSystem.Products.Dtos;

namespace SimpleInvoiceSystem.Products
{
    public class ProductAppService : IProductAppService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductAppService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<GetAllProductOutput> GetAllProduct()
        {
            return new GetAllProductOutput
                   {
                       Product = Mapper.Map<List<ProductDto>>(await _productRepository.GetAllListAsync())
                   };
        }
    }
}