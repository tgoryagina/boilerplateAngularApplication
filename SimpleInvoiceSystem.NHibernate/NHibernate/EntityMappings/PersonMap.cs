using Abp.NHibernate.EntityMappings;
using SimpleInvoiceSystem.People;

namespace SimpleInvoiceSystem.NHibernate.EntityMappings
{
    public class PersonMap : EntityMap<Person>
    {
        public PersonMap()
            : base("StsPeople")
        {
            Map(x => x.Name);
        }
    }
}
