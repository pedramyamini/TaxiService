namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "SecurityQuestion", c => c.String());
            AddColumn("dbo.Users", "SecurityAnswer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "SecurityAnswer");
            DropColumn("dbo.Users", "SecurityQuestion");
        }
    }
}
