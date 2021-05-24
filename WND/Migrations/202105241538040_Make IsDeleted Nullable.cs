namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeIsDeletedNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "IsDeleted", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
        }
    }
}
