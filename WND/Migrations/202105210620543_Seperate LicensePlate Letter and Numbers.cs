namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeperateLicensePlateLetterandNumbers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "LicensePlateNumbers", c => c.String());
            AddColumn("dbo.Cars", "LicensePlateLetter", c => c.String());
            DropColumn("dbo.Cars", "LicensePlate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "LicensePlate", c => c.String());
            DropColumn("dbo.Cars", "LicensePlateLetter");
            DropColumn("dbo.Cars", "LicensePlateNumbers");
        }
    }
}
