namespace Tridion.Snitch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class snitch3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.UserActions",
                c => new
                    {
                        UserActionId = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        ActionName = c.String(),
                        ActionDetails = c.String(),
                        ActionTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserActionId)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserActions", "UserID", "dbo.Users");
            DropIndex("dbo.UserActions", new[] { "UserID" });
            DropTable("dbo.UserActions");
            DropTable("dbo.Users");
        }
    }
}
