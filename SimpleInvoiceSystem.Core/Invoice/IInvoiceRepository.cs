using System.Collections.Generic;
using Abp.Domain.Repositories;

namespace SimpleInvoiceSystem
{
    public interface IInvoiceRepository : IRepository<Invoice, long>
    {
        List<Invoice> GetAllWithProduct(int? productId);
    }
}
