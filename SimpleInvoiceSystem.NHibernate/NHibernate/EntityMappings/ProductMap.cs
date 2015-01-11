using Abp.NHibernate.EntityMappings;
using NHibernate.Type;
using SimpleInvoiceSystem.People;

namespace SimpleInvoiceSystem.NHibernate.EntityMappings
{
    public class ProductMap : EntityMap<Product>
    {
        public ProductMap()
            : base("Products")
        {
            Map(x => x.Name);
            Map(x => x.Price);
        }
    }
}

