namespace bazy_ostateczne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class corect : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BinaryResults", "IDResult", c => c.Int(nullable: false));
            AddColumn("dbo.BinaryCoupons", "IDBetting", c => c.Int(nullable: false));
            DropColumn("dbo.BinaryResults", "ID_wyniku");
            DropColumn("dbo.BinaryCoupons", "Id_Betting");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BinaryCoupons", "Id_Betting", c => c.Int(nullable: false));
            AddColumn("dbo.BinaryResults", "ID_wyniku", c => c.Int(nullable: false));
            DropColumn("dbo.BinaryCoupons", "IDBetting");
            DropColumn("dbo.BinaryResults", "IDResult");
        }
    }
}
