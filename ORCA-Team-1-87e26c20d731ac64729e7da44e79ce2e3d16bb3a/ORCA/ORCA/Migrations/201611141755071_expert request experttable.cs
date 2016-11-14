namespace ORCA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expertrequestexperttable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experts", "Requested", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Experts", "Requested");
        }
    }
}
