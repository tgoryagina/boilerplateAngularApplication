using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace SimpleInvoiceSystem
{

    [Table("Invoices")]
    public class Invoice : Entity<long>, IHasCreationTime
    {

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        
        public virtual int? ProductId { get; set; }

        public virtual int? Quantity { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public virtual int? Price { get; set; }

        public Invoice()
        {
            CreationTime = DateTime.Now;
        }
    }
}
