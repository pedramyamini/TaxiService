namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsDeletedToUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Users", "IsDeleted1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "IsDeleted1", c => c.Boolean());
            AlterColumn("dbo.Users", "IsDeleted", c => c.Boolean());
        }
    }
}
