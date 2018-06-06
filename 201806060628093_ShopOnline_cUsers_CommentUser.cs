namespace ModelShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopOnline_cUsers_CommentUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("User.CommentUser", "Users_UserName", c => c.String(maxLength: 128));
            CreateIndex("User.CommentUser", "Users_UserName");
            AddForeignKey("User.CommentUser", "Users_UserName", "User.Users", "UserName");
            DropColumn("User.CommentUser", "Parent");
        }
        
        public override void Down()
        {
            AddColumn("User.CommentUser", "Parent", c => c.String(maxLength: 20));
            DropForeignKey("User.CommentUser", "Users_UserName", "User.Users");
            DropIndex("User.CommentUser", new[] { "Users_UserName" });
            DropColumn("User.CommentUser", "Users_UserName");
        }
    }
}
