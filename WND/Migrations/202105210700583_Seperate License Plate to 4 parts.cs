namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeperateLicensePlateto4parts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "LicensePlate1", c => c.String());
            AddColumn("dbo.Cars", "LicensePlate3", c => c.String());
            AddColumn("dbo.Cars", "LicensePlate4", c => c.String());
            AddColumn("dbo.Cars", "LicensePlate2", c => c.String());
            DropColumn("dbo.Cars", "LicensePlateNumbers");
            DropColumn("dbo.Cars", "LicensePlateLetter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "LicensePlateLetter", c => c.String());
            AddColumn("dbo.Cars", "LicensePlateNumbers", c => c.String());
            DropColumn("dbo.Cars", "LicensePlate2");
            DropColumn("dbo.Cars", "LicensePlate4");
            DropColumn("dbo.Cars", "LicensePlate3");
            DropColumn("dbo.Cars", "LicensePlate1");
        }
    }
}
