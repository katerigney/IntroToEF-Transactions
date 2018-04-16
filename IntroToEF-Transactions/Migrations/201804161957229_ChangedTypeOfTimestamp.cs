namespace IntroToEF_Transactions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTypeOfTimestamp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "Timestamp", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "Timestamp", c => c.String());
        }
    }
}
