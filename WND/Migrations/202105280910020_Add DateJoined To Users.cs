namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateJoinedToUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Mobile = c.String(nullable: false, maxLength: 11),
                        Role = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DateJoined = c.DateTime(nullable: false),
                        Username = c.String(maxLength: 20),
                        Password = c.String(),
                        SecurityQuestion = c.String(),
                        SecurityAnswer = c.String(),
                        TaxiName = c.String(),
                        SharePercent = c.Int(),
                        Address = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Mobile);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Model = c.String(nullable: false),
                        LicensePlate1 = c.String(),
                        LicensePlate3 = c.String(),
                        LicensePlate4 = c.String(),
                        LicensePlate2 = c.String(),
                        Color = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        OriginInDetail = c.String(),
                        DestinationInDetail = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Delay = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        DriverId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Transactions", t => t.Id)
                .ForeignKey("dbo.Users", t => t.DriverId)
                .Index(t => t.Id)
                .Index(t => t.CustomerId)
                .Index(t => t.DriverId);
            
            CreateTable(
                "dbo.ServicePaths",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceId = c.Int(nullable: false),
                        PathId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paths", t => t.PathId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.PathId);
            
            CreateTable(
                "dbo.Paths",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Origin = c.String(nullable: false, maxLength: 250),
                        Destination = c.String(nullable: false, maxLength: 250),
                        OriginDestination = c.String(),
                        Cost = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.Origin, t.Destination }, unique: true);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "DriverId", "dbo.Users");
            DropForeignKey("dbo.Services", "Id", "dbo.Transactions");
            DropForeignKey("dbo.ServicePaths", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.ServicePaths", "PathId", "dbo.Paths");
            DropForeignKey("dbo.Services", "CustomerId", "dbo.Users");
            DropForeignKey("dbo.Cars", "Id", "dbo.Users");
            DropIndex("dbo.Paths", new[] { "Origin", "Destination" });
            DropIndex("dbo.ServicePaths", new[] { "PathId" });
            DropIndex("dbo.ServicePaths", new[] { "ServiceId" });
            DropIndex("dbo.Services", new[] { "DriverId" });
            DropIndex("dbo.Services", new[] { "CustomerId" });
            DropIndex("dbo.Services", new[] { "Id" });
            DropIndex("dbo.Cars", new[] { "Id" });
            DropIndex("dbo.Users", new[] { "Mobile" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Paths");
            DropTable("dbo.ServicePaths");
            DropTable("dbo.Services");
            DropTable("dbo.Cars");
            DropTable("dbo.Users");
        }
    }
}
