using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace SimpleInvoiceSystem
{
    [Table("Products")]
    public class Product : Entity
    {
        public virtual string Name { get; set; }

        public virtual int Price { get; set; }
    }
}