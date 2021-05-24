namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsDeletedtoDriverandCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsDeleted", c => c.Boolean());
            AddColumn("dbo.Users", "IsDeleted1", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IsDeleted1");
            DropColumn("dbo.Users", "IsDeleted");
        }
    }
}
