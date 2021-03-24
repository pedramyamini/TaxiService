namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migAddDriverCar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Mobile = c.String(),
                        Phone = c.String(),
                        Role = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        SecurityQuestion = c.String(),
                        SecurityAnswer = c.String(),
                        SharePercent = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Model = c.String(),
                        LicensePlate = c.String(),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Id", "dbo.Users");
            DropIndex("dbo.Cars", new[] { "Id" });
            DropTable("dbo.Cars");
            DropTable("dbo.Users");
        }
    }
}
