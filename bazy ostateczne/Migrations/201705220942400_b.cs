namespace bazy_ostateczne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Bettings", newName: "Betting");
            RenameTable(name: "dbo.BinaryResults", newName: "BinaryResult");
            RenameTable(name: "dbo.Results", newName: "Result");
            RenameTable(name: "dbo.Clients", newName: "Client");
            RenameTable(name: "dbo.BinaryCoupons", newName: "BinaryCoupon");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.BinaryCoupon", newName: "BinaryCoupons");
            RenameTable(name: "dbo.Client", newName: "Clients");
            RenameTable(name: "dbo.Result", newName: "Results");
            RenameTable(name: "dbo.BinaryResult", newName: "BinaryResults");
            RenameTable(name: "dbo.Betting", newName: "Bettings");
        }
    }
}
