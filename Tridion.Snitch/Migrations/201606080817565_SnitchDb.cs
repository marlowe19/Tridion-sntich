namespace Tridion.Snitch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SnitchDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.UserActions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ActionName = c.String(),
                        ActionDetails = c.String(),
                        ActionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserActions");
            DropTable("dbo.Users");
        }
    }
}
