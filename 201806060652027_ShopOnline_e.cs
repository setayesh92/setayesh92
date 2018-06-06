namespace ModelShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopOnline_e : DbMigration
    {
        public override void Up()
        {
            DropIndex("Production.Product", new[] { "Category_Id1" });
            DropColumn("Production.Product", "Category_Id");
            RenameColumn(table: "Production.Product", name: "Category_Id1", newName: "Category_Id");
            AlterColumn("Production.Product", "Category_Id", c => c.Int());
            CreateIndex("Production.Product", "Category_Id");
        }
        
        public override void Down()
        {
            DropIndex("Production.Product", new[] { "Category_Id" });
            AlterColumn("Production.Product", "Category_Id", c => c.Int(nullable: false));
            RenameColumn(table: "Production.Product", name: "Category_Id", newName: "Category_Id1");
            AddColumn("Production.Product", "Category_Id", c => c.Int(nullable: false));
            CreateIndex("Production.Product", "Category_Id1");
        }
    }
}
