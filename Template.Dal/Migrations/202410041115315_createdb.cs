namespace Template.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        ProductId = c.Guid(nullable: false),
                        Weight = c.Double(nullable: false),
                        AgeCategory = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountInStock = c.Int(nullable: false),
                        InStock = c.Boolean(nullable: false),
                        AnimalType = c.Int(nullable: false),
                        Brand = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Toys",
                c => new
                    {
                        ProductId = c.Guid(nullable: false),
                        ToySize = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountInStock = c.Int(nullable: false),
                        InStock = c.Boolean(nullable: false),
                        AnimalType = c.Int(nullable: false),
                        Brand = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Toys");
            DropTable("dbo.Foods");
        }
    }
}
