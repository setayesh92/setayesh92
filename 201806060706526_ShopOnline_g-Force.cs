namespace ModelShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopOnline_gForce : DbMigration
    {
        public override void Up()
        {
            AddColumn("User.AddressUser", "Users_UserName", c => c.String(maxLength: 128));
            CreateIndex("User.AddressUser", "Users_UserName");
            AddForeignKey("User.AddressUser", "Users_UserName", "User.Users", "UserName");
        }
        
        public override void Down()
        {
            DropForeignKey("User.AddressUser", "Users_UserName", "User.Users");
            DropIndex("User.AddressUser", new[] { "Users_UserName" });
            DropColumn("User.AddressUser", "Users_UserName");
        }
    }
}
