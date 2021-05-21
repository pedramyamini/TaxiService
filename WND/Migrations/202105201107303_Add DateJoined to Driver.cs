namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateJoinedtoDriver : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "DateJoined", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "DateJoined");
        }
    }
}
