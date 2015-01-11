using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SimpleInvoiceSystem.EntityFramework.Repositories
{
    /// <summary>
    /// We declare a base repository class for our application.
    /// It inherits from <see cref="EfRepositoryBase{TDbContext,TEntity,TPrimaryKey}"/>.
    /// We can add here common methods for all our repositories.
    /// </summary>
    public abstract class SimpleInvoiceSystemRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SimpleInvoiceSystemDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SimpleInvoiceSystemRepositoryBase(IDbContextProvider<SimpleInvoiceSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }

    /// <summary>
    /// A shortcut of <see cref="SimpleInvoiceSystemRepositoryBase{TEntity,TPrimaryKey}"/> for Entities with primary key type <see cref="int"/>.
    /// </summary>
    public abstract class SimpleInvoiceSystemRepositoryBase<TEntity> : SimpleInvoiceSystemRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SimpleInvoiceSystemRepositoryBase(IDbContextProvider<SimpleInvoiceSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
