namespace ModelShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopOnline_f : DbMigration
    {
        public override void Up()
        {
            DropColumn("User.CommentUser", "NameUser");
        }
        
        public override void Down()
        {
            AddColumn("User.CommentUser", "NameUser", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
