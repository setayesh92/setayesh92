namespace ModelShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopOnline_b : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "User.AddressUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressLocate = c.String(maxLength: 20),
                        NameOstan = c.String(nullable: false, maxLength: 20),
                        Namecity = c.String(nullable: false, maxLength: 15),
                        Descripton = c.String(maxLength: 50),
                        Telephone = c.String(nullable: false, maxLength: 11),
                        Mobile = c.String(nullable: false, maxLength: 11),
                        PostalCode = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Buy.BuyFactor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.String(),
                        BuyDate = c.DateTime(nullable: false),
                        Number = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AddressTahvil = c.Int(),
                        StatuseFactor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Buy.BuyProduct",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BuyProductId = c.Int(nullable: false),
                        BuyName = c.String(maxLength: 30),
                        BuyNumber = c.Int(nullable: false),
                        BuyTechnique = c.String(maxLength: 25),
                        SizeBoard = c.String(maxLength: 20),
                        FirstPrice = c.Double(nullable: false),
                        Reduction = c.Double(nullable: false),
                        LastPrice = c.Double(nullable: false),
                        PaikName = c.String(),
                        FactorId = c.Int(nullable: false),
                        Description = c.String(maxLength: 80),
                        Statuse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Production.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Production.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        ModelName = c.String(),
                        FirstPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Reduction = c.Double(nullable: false),
                        LastPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsAvailable = c.Boolean(nullable: false),
                        Number = c.Int(nullable: false),
                        TimeGaranty = c.Int(nullable: false),
                        UrlImage = c.String(maxLength: 150),
                        Category_Id = c.Int(nullable: false),
                        Category_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Production.Category", t => t.Category_Id1)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Category_Id1);
            
            CreateTable(
                "User.CommentUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameUser = c.String(nullable: false, maxLength: 50),
                        ProductIdComment = c.Int(nullable: false),
                        Comment = c.String(maxLength: 50),
                        Parent = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Production.DetailProductCarpet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOfRidger = c.Int(nullable: false),
                        DemensionsTocm = c.String(),
                        TypeOfTissue = c.String(),
                        Genus = c.String(),
                        Clips = c.Double(nullable: false),
                        Knot = c.Double(nullable: false),
                        Color = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Production.DetailProductPainting",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameBoard = c.String(maxLength: 30),
                        NameArtist = c.String(maxLength: 30),
                        SizeBoard = c.String(maxLength: 20),
                        Technique = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "User.Users",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Passworde = c.String(nullable: false, maxLength: 30),
                        FullName = c.String(nullable: false, maxLength: 30),
                        Rule = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Production.Product", "Category_Id1", "Production.Category");
            DropIndex("Production.Product", new[] { "Category_Id1" });
            DropIndex("Production.Product", new[] { "Name" });
            DropTable("User.Users");
            DropTable("Production.DetailProductPainting");
            DropTable("Production.DetailProductCarpet");
            DropTable("User.CommentUser");
            DropTable("Production.Product");
            DropTable("Production.Category");
            DropTable("Buy.BuyProduct");
            DropTable("Buy.BuyFactor");
            DropTable("User.AddressUser");
        }
    }
}
