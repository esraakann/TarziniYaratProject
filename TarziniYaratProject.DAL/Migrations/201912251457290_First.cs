namespace TarziniYaratProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        Country = c.String(nullable: false, maxLength: 30),
                        Province = c.String(nullable: false, maxLength: 30),
                        Distrinct = c.String(nullable: false, maxLength: 30),
                        FullAddress = c.String(nullable: false, maxLength: 300),
                        PostCode = c.Int(nullable: false),
                        IsActiveAddress = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.Person", t => t.PersonID)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        PersonType = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        CellPhone = c.String(nullable: false, maxLength: 13, fixedLength: true, unicode: false),
                        Gender = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Combine",
                c => new
                    {
                        CombineID = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                        CombineImage = c.String(nullable: false, maxLength: 500),
                        PersonID = c.Int(nullable: false),
                        CommentCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CombineID)
                .ForeignKey("dbo.Person", t => t.PersonID)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 250),
                        CommentDate = c.DateTime(nullable: false, storeType: "date"),
                        PersonID = c.Int(nullable: false),
                        CombineID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Combine", t => t.CombineID)
                .ForeignKey("dbo.Person", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID)
                .Index(t => t.CombineID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Like",
                c => new
                    {
                        LikeID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        CommentID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        CombineID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LikeID)
                .ForeignKey("dbo.Combine", t => t.CombineID)
                .ForeignKey("dbo.Comment", t => t.CommentID)
                .ForeignKey("dbo.Person", t => t.PersonID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .Index(t => t.PersonID)
                .Index(t => t.CommentID)
                .Index(t => t.ProductID)
                .Index(t => t.CombineID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        BrandID = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 50),
                        Title = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Discount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Brand", t => t.BrandID, cascadeDelete: true)
                .ForeignKey("dbo.Category", t => t.CategoryID)
                .Index(t => t.BrandID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        BrandID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.BrandID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Decription = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(nullable: false, maxLength: 500),
                        ProductID = c.Int(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImageID)
                .ForeignKey("dbo.Person", t => t.PersonID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.ProductDetail",
                c => new
                    {
                        ProductDetailID = c.Int(nullable: false, identity: true),
                        Size = c.String(nullable: false, maxLength: 10),
                        Color = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductDetailID)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.PurchaseDetail",
                c => new
                    {
                        PurchaseDetailID = c.Int(nullable: false, identity: true),
                        PurchaseID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.PurchaseDetailID)
                .ForeignKey("dbo.Purchase", t => t.PurchaseID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.PurchaseID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Purchase",
                c => new
                    {
                        PurchaseID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        money = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CargoStatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseID)
                .ForeignKey("dbo.CargoStatus", t => t.CargoStatusID, cascadeDelete: true)
                .ForeignKey("dbo.Person", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID)
                .Index(t => t.CargoStatusID);
            
            CreateTable(
                "dbo.CargoStatus",
                c => new
                    {
                        CargoStatusID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CargoStatusID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Address", "PersonID", "dbo.Person");
            DropForeignKey("dbo.Comment", "PersonID", "dbo.Person");
            DropForeignKey("dbo.Combine", "PersonID", "dbo.Person");
            DropForeignKey("dbo.Comment", "CombineID", "dbo.Combine");
            DropForeignKey("dbo.Comment", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Like", "ProductID", "dbo.Product");
            DropForeignKey("dbo.PurchaseDetail", "ProductID", "dbo.Product");
            DropForeignKey("dbo.PurchaseDetail", "PurchaseID", "dbo.Purchase");
            DropForeignKey("dbo.Purchase", "PersonID", "dbo.Person");
            DropForeignKey("dbo.Purchase", "CargoStatusID", "dbo.CargoStatus");
            DropForeignKey("dbo.ProductDetail", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Image", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Image", "PersonID", "dbo.Person");
            DropForeignKey("dbo.Product", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.Product", "BrandID", "dbo.Brand");
            DropForeignKey("dbo.Like", "PersonID", "dbo.Person");
            DropForeignKey("dbo.Like", "CommentID", "dbo.Comment");
            DropForeignKey("dbo.Like", "CombineID", "dbo.Combine");
            DropIndex("dbo.Purchase", new[] { "CargoStatusID" });
            DropIndex("dbo.Purchase", new[] { "PersonID" });
            DropIndex("dbo.PurchaseDetail", new[] { "ProductID" });
            DropIndex("dbo.PurchaseDetail", new[] { "PurchaseID" });
            DropIndex("dbo.ProductDetail", new[] { "ProductID" });
            DropIndex("dbo.Image", new[] { "PersonID" });
            DropIndex("dbo.Image", new[] { "ProductID" });
            DropIndex("dbo.Product", new[] { "CategoryID" });
            DropIndex("dbo.Product", new[] { "BrandID" });
            DropIndex("dbo.Like", new[] { "CombineID" });
            DropIndex("dbo.Like", new[] { "ProductID" });
            DropIndex("dbo.Like", new[] { "CommentID" });
            DropIndex("dbo.Like", new[] { "PersonID" });
            DropIndex("dbo.Comment", new[] { "ProductID" });
            DropIndex("dbo.Comment", new[] { "CombineID" });
            DropIndex("dbo.Comment", new[] { "PersonID" });
            DropIndex("dbo.Combine", new[] { "PersonID" });
            DropIndex("dbo.Address", new[] { "PersonID" });
            DropTable("dbo.CargoStatus");
            DropTable("dbo.Purchase");
            DropTable("dbo.PurchaseDetail");
            DropTable("dbo.ProductDetail");
            DropTable("dbo.Image");
            DropTable("dbo.Category");
            DropTable("dbo.Brand");
            DropTable("dbo.Product");
            DropTable("dbo.Like");
            DropTable("dbo.Comment");
            DropTable("dbo.Combine");
            DropTable("dbo.Person");
            DropTable("dbo.Address");
        }
    }
}
