using FluentMigrator;

namespace SimpleInvoiceSystem.DbMigrations.V20140410
{
    [Migration(2014041001)]
    public class _03_CreateProductTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Products")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable() //.WithIdAsInt32() can be used here for shortcut.
                .WithColumn("Name").AsString(32).NotNullable()
                .WithColumn("Price").AsInt32().NotNullable();

            Insert.IntoTable("Products")
                .Row(new { Name = "One", Price = 10 })
                .Row(new { Name = "Two", Price = 20 })
                .Row(new { Name = "Three", Price = 30 })
                .Row(new { Name = "Four", Price = 40 });
        }
    }
}
