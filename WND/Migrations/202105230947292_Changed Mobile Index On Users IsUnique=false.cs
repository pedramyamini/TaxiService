namespace WND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMobileIndexOnUsersIsUniquefalse : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "Mobile" });
            CreateIndex("dbo.Users", "Mobile");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Mobile" });
            CreateIndex("dbo.Users", "Mobile", unique: true);
        }
    }
}
