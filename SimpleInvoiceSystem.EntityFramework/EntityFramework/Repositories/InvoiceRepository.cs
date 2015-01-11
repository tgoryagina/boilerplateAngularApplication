using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Abp.EntityFramework;

namespace SimpleInvoiceSystem.EntityFramework.Repositories
{
    internal class InvoiceRepository : SimpleInvoiceSystemRepositoryBase<Invoice, long>, IInvoiceRepository
    {
        public InvoiceRepository(IDbContextProvider<SimpleInvoiceSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public List<Invoice> GetAllWithProduct(int? productId)
        {
            IQueryable<Invoice> query = GetAll();

            if (productId.HasValue)
            {
                query = query.Where(invoice => invoice.Product.Id == productId.Value);
            }

            return query
                .OrderByDescending(invoice => invoice.CreationTime)
                .Include(invoice => invoice.Product)
                .ToList();
        }
    }
}
