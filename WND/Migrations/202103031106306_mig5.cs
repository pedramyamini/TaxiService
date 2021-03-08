namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "FullName", c => c.String());
            AlterColumn("dbo.Users", "Mobile", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Mobile", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "FullName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
