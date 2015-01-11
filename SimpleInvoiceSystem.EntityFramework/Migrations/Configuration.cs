using System.Data.Entity.Migrations;
using SimpleInvoiceSystem.EntityFramework;
using SimpleInvoiceSystem.People;

namespace SimpleInvoiceSystem.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SimpleInvoiceSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SimpleInvoiceSystemDbContext context)
        {
            context.People.AddOrUpdate(
                p => p.Name,
                new Person {Name = "Isaac Asimov"},
                new Person {Name = "Thomas More"},
                new Person {Name = "George Orwell"},
                new Person {Name = "Douglas Adams"}
                );

            context.Product.AddOrUpdate(
                p => p.Name,
                new Product {Name = "One", Price = 10},
                new Product {Name = "Two", Price = 20},
                new Product {Name = "Three", Price = 30},
                new Product {Name = "Four", Price = 40}
                );
        }
    }
}
