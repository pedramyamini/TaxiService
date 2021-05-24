namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsDeletedToPath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Paths", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Paths", "IsDeleted");
        }
    }
}
