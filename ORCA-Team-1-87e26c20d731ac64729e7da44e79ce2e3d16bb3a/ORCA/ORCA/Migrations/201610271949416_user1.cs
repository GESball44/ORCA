namespace ORCA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PhoneNumber", c => c.String());
            AddColumn("dbo.Users", "State", c => c.String());
            AddColumn("dbo.Users", "Country", c => c.String());
            AddColumn("dbo.Users", "City", c => c.String());
            AddColumn("dbo.Users", "Zip", c => c.String());
            AddColumn("dbo.Users", "Organization", c => c.String());
            AddColumn("dbo.Users", "UserType", c => c.String());
            AddColumn("dbo.Users", "IsAdmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "CreateDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "CreateDate");
            DropColumn("dbo.Users", "IsAdmin");
            DropColumn("dbo.Users", "UserType");
            DropColumn("dbo.Users", "Organization");
            DropColumn("dbo.Users", "Zip");
            DropColumn("dbo.Users", "City");
            DropColumn("dbo.Users", "Country");
            DropColumn("dbo.Users", "State");
            DropColumn("dbo.Users", "PhoneNumber");
        }
    }
}
