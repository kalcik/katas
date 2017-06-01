namespace CarRental.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        CarBrand = c.String(),
                        LicenceNumber = c.String(),
                        KilometerReading = c.Single(nullable: false),
                        Category = c.String(),
                        OfficeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.Offices", t => t.OfficeId, cascadeDelete: true)
                .Index(t => t.OfficeId);
            
            CreateTable(
                "dbo.Offices",
                c => new
                    {
                        OfficeId = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        Postcode = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.OfficeId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        CustomerType = c.Int(nullable: false),
                        Street = c.String(),
                        City = c.String(),
                        Postcode = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.InvoiceId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        InvoiceId = c.Int(),
                        ReservationStart = c.DateTime(nullable: false),
                        ReservationEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId)
                .Index(t => t.CarId)
                .Index(t => t.CustomerId)
                .Index(t => t.InvoiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "InvoiceId", "dbo.Invoices");
            DropForeignKey("dbo.Reservations", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Reservations", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Cars", "OfficeId", "dbo.Offices");
            DropIndex("dbo.Reservations", new[] { "InvoiceId" });
            DropIndex("dbo.Reservations", new[] { "CustomerId" });
            DropIndex("dbo.Reservations", new[] { "CarId" });
            DropIndex("dbo.Cars", new[] { "OfficeId" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
            DropTable("dbo.Offices");
            DropTable("dbo.Cars");
        }
    }
}
