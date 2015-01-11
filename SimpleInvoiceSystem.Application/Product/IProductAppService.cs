using System.Threading.Tasks;
using Abp.Application.Services;
using SimpleInvoiceSystem.Products.Dtos;

namespace SimpleInvoiceSystem.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<GetAllProductOutput> GetAllProduct();
    }
}
