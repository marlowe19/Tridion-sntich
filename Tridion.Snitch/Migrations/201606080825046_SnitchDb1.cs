namespace Tridion.Snitch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SnitchDb1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserActions", "ActionTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserActions", "ActionTime", c => c.DateTime(nullable: false));
        }
    }
}
