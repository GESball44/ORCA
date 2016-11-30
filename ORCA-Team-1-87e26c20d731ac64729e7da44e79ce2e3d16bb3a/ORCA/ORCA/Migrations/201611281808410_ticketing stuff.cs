namespace ORCA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ticketingstuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "UserEmail", c => c.String());
            AddColumn("dbo.Tickets", "Text", c => c.String());
            AddColumn("dbo.Tickets", "CreateDate", c => c.String());
            AddColumn("dbo.Tickets", "ExpertEmail", c => c.String());
            DropColumn("dbo.Responses", "ResponseId");
            DropColumn("dbo.Tickets", "TickId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "TickId", c => c.String());
            AddColumn("dbo.Responses", "ResponseId", c => c.String());
            DropColumn("dbo.Tickets", "ExpertEmail");
            DropColumn("dbo.Tickets", "CreateDate");
            DropColumn("dbo.Tickets", "Text");
            DropColumn("dbo.Tickets", "UserEmail");
        }
    }
}
