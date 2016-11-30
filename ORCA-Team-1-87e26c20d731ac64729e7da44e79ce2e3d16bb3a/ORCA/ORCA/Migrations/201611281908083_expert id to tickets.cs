namespace ORCA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expertidtotickets : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "ExpertID", c => c.String());
            DropColumn("dbo.Tickets", "ExpertEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "ExpertEmail", c => c.String());
            DropColumn("dbo.Tickets", "ExpertID");
        }
    }
}
