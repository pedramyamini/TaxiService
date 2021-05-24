namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "IsDeleted", c => c.Boolean());
        }
    }
}
