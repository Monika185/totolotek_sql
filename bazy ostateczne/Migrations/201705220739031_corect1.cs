namespace bazy_ostateczne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class corect1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bettings", "ID_Client");
            DropColumn("dbo.Bettings", "ID_Result");
            DropColumn("dbo.BinaryResults", "IDResult");
            DropColumn("dbo.Results", "ID_Draw");
            DropColumn("dbo.BinaryCoupons", "IDBetting");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BinaryCoupons", "IDBetting", c => c.Int(nullable: false));
            AddColumn("dbo.Results", "ID_Draw", c => c.Int());
            AddColumn("dbo.BinaryResults", "IDResult", c => c.Int(nullable: false));
            AddColumn("dbo.Bettings", "ID_Result", c => c.Int());
            AddColumn("dbo.Bettings", "ID_Client", c => c.Int());
        }
    }
}
