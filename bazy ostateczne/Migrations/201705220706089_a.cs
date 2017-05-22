namespace bazy_ostateczne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bettings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        L1 = c.Int(),
                        L2 = c.Int(),
                        L3 = c.Int(),
                        L4 = c.Int(),
                        L5 = c.Int(),
                        L6 = c.Int(),
                        Id_Client = c.Int(),
                        ID_Result = c.Int(),
                        Result_ID = c.Int(),
                        Client_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Results", t => t.Result_ID)
                .ForeignKey("dbo.Clients", t => t.Client_ID)
                .Index(t => t.Result_ID)
                .Index(t => t.Client_ID);
            
            CreateTable(
                "dbo.BinaryResults",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        ID_wyniku = c.Int(nullable: false),
                        L1 = c.Boolean(),
                        L2 = c.Boolean(),
                        L3 = c.Boolean(),
                        L4 = c.Boolean(),
                        L5 = c.Boolean(),
                        L6 = c.Boolean(),
                        L7 = c.Boolean(),
                        L8 = c.Boolean(),
                        L9 = c.Boolean(),
                        L10 = c.Boolean(),
                        L11 = c.Boolean(),
                        L12 = c.Boolean(),
                        L13 = c.Boolean(),
                        L14 = c.Boolean(),
                        L15 = c.Boolean(),
                        L16 = c.Boolean(),
                        L17 = c.Boolean(),
                        L18 = c.Boolean(),
                        L19 = c.Boolean(),
                        L20 = c.Boolean(),
                        L21 = c.Boolean(),
                        L22 = c.Boolean(),
                        L23 = c.Boolean(),
                        L24 = c.Boolean(),
                        L25 = c.Boolean(),
                        L26 = c.Boolean(),
                        L27 = c.Boolean(),
                        L28 = c.Boolean(),
                        L29 = c.Boolean(),
                        L30 = c.Boolean(),
                        L31 = c.Boolean(),
                        L32 = c.Boolean(),
                        L33 = c.Boolean(),
                        L34 = c.Boolean(),
                        L35 = c.Boolean(),
                        L36 = c.Boolean(),
                        L37 = c.Boolean(),
                        L38 = c.Boolean(),
                        L39 = c.Boolean(),
                        L40 = c.Boolean(),
                        L41 = c.Boolean(),
                        L42 = c.Boolean(),
                        L43 = c.Boolean(),
                        L44 = c.Boolean(),
                        L45 = c.Boolean(),
                        L46 = c.Boolean(),
                        L47 = c.Boolean(),
                        L48 = c.Boolean(),
                        L49 = c.Boolean(),
                        Result_ID = c.Int(),
                        Betting_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Results", t => t.Result_ID)
                .ForeignKey("dbo.Bettings", t => t.Betting_ID)
                .Index(t => t.Result_ID)
                .Index(t => t.Betting_ID);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        ID_Draw = c.Int(),
                        NumbersCoupon = c.Int(),
                        NumberWin3 = c.Int(),
                        NumberWin4 = c.Int(),
                        NumberWin5 = c.Int(),
                        NumberWin6 = c.Int(),
                        L1 = c.Int(),
                        L2 = c.Int(),
                        L3 = c.Int(),
                        L4 = c.Int(),
                        L5 = c.Int(),
                        L6 = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        FirstName = c.String(),
                        Name = c.String(),
                        NameBetting = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BinaryCoupons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Id_Betting = c.Int(nullable: false),
                        L1 = c.Boolean(),
                        L2 = c.Boolean(),
                        L3 = c.Boolean(),
                        L4 = c.Boolean(),
                        L5 = c.Boolean(),
                        L6 = c.Boolean(),
                        L7 = c.Boolean(),
                        L8 = c.Boolean(),
                        L9 = c.Boolean(),
                        L10 = c.Boolean(),
                        L11 = c.Boolean(),
                        L12 = c.Boolean(),
                        L13 = c.Boolean(),
                        L14 = c.Boolean(),
                        L15 = c.Boolean(),
                        L16 = c.Boolean(),
                        L17 = c.Boolean(),
                        L18 = c.Boolean(),
                        L19 = c.Boolean(),
                        L20 = c.Boolean(),
                        L21 = c.Boolean(),
                        L22 = c.Boolean(),
                        L23 = c.Boolean(),
                        L24 = c.Boolean(),
                        L25 = c.Boolean(),
                        L26 = c.Boolean(),
                        L27 = c.Boolean(),
                        L28 = c.Boolean(),
                        L29 = c.Boolean(),
                        L30 = c.Boolean(),
                        L31 = c.Boolean(),
                        L32 = c.Boolean(),
                        L33 = c.Boolean(),
                        L34 = c.Boolean(),
                        L35 = c.Boolean(),
                        L36 = c.Boolean(),
                        L37 = c.Boolean(),
                        L38 = c.Boolean(),
                        L39 = c.Boolean(),
                        L40 = c.Boolean(),
                        L41 = c.Boolean(),
                        L42 = c.Boolean(),
                        L43 = c.Boolean(),
                        L44 = c.Boolean(),
                        L45 = c.Boolean(),
                        L46 = c.Boolean(),
                        L47 = c.Boolean(),
                        L48 = c.Boolean(),
                        L49 = c.Boolean(),
                        Betting_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Bettings", t => t.Betting_ID)
                .Index(t => t.Betting_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BinaryCoupons", "Betting_ID", "dbo.Bettings");
            DropForeignKey("dbo.Bettings", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.BinaryResults", "Betting_ID", "dbo.Bettings");
            DropForeignKey("dbo.Bettings", "Result_ID", "dbo.Results");
            DropForeignKey("dbo.BinaryResults", "Result_ID", "dbo.Results");
            DropIndex("dbo.BinaryCoupons", new[] { "Betting_ID" });
            DropIndex("dbo.BinaryResults", new[] { "Betting_ID" });
            DropIndex("dbo.BinaryResults", new[] { "Result_ID" });
            DropIndex("dbo.Bettings", new[] { "Client_ID" });
            DropIndex("dbo.Bettings", new[] { "Result_ID" });
            DropTable("dbo.BinaryCoupons");
            DropTable("dbo.Clients");
            DropTable("dbo.Results");
            DropTable("dbo.BinaryResults");
            DropTable("dbo.Bettings");
        }
    }
}
