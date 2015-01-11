using FluentMigrator;

namespace SimpleInvoiceSystem.DbMigrations.V20140410
{
    /// <summary>
    /// Defines a migration (database schema change).
    /// Creates Tasks table.
    /// See FluentMigrator's documentation for more information.
    /// </summary>
    [Migration(2014041002)]
    public class _02_CreateInvoiceTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Invoices")
                .WithColumn("Id").AsInt64().Identity().PrimaryKey().NotNullable() //.WithIdAsInt64() can be used here for shortcut.
                .WithColumn("ProductId").AsInt32().ForeignKey("Products", "Id").Nullable()
                .WithColumn("Quantity").AsInt32().NotNullable()
                .WithColumn("CreationTime").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentDateTime); //WithCreationTimeColumn() can be used here for shortcut.
        }
    }
}