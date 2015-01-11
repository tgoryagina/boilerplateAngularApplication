using Abp.NHibernate.EntityMappings;
using SimpleInvoiceSystem.Tasks;

namespace SimpleInvoiceSystem.NHibernate.EntityMappings
{
    public class InvoiceMap : EntityMap<Invoice, long>
    {
        public InvoiceMap()
            : base("Invoices")
        {
            Map(x => x.Quantity);
            Map(x => x.CreationTime);
            References(x => x.Product).Column("ProductId").LazyLoad();
        }
    }
}
