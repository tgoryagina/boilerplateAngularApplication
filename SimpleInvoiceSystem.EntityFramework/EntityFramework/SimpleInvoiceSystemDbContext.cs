using System.Data.Entity;
using Abp.EntityFramework;
using SimpleInvoiceSystem.People;
using SimpleInvoiceSystem.Tasks;

namespace SimpleInvoiceSystem.EntityFramework
{
    public class SimpleInvoiceSystemDbContext : AbpDbContext
    {
        public virtual IDbSet<Task> Tasks { get; set; }

        public virtual IDbSet<Person> People { get; set; }

        public virtual IDbSet<Invoice> Invoice { get; set; }

        public virtual IDbSet<Product> Product { get; set; }

        public SimpleInvoiceSystemDbContext()
            : base("Default")
        {

        }

        public SimpleInvoiceSystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            
        }
    }
}
