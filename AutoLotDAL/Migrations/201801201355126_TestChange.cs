namespace AutoLotDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Inventories", "Make", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Inventories", "Make", c => c.String(maxLength: 50));
        }
    }
}
