using System.Collections.Generic;
using System.Linq;
using Abp.NHibernate;
using Abp.NHibernate.Repositories;
using NHibernate.Linq;

namespace SimpleInvoiceSystem.NHibernate.Repositories
{
    public class InvoiceRepository : NhRepositoryBase<Invoice, long>, IInvoiceRepository
    {
        public InvoiceRepository(ISessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }

        public List<Invoice> GetAllWithProduct(int? boundProductId)
        {
            IQueryable<Invoice> query = GetAll();

            if (boundProductId.HasValue)
            {
                query = query.Where(invoice => invoice.Product.Id == boundProductId.Value);
            }

            return query
                .OrderByDescending(invoice => invoice.CreationTime)
                .Fetch(invoice => invoice.Product) //Fetch assigned person in a single query
                .ToList();
        }
    }
}
