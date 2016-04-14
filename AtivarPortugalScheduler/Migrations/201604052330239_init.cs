namespace AtivarPortugalScheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyName = c.String(nullable: false, maxLength: 128),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.CompanyName);
            
            CreateTable(
                "dbo.Meeting",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartupName = c.String(maxLength: 128),
                        CompanyName = c.String(maxLength: 128),
                        RoomName = c.String(maxLength: 128),
                        MeetingTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company", t => t.CompanyName)
                .ForeignKey("dbo.Room", t => t.RoomName)
                .ForeignKey("dbo.StartupM", t => t.StartupName)
                .Index(t => t.StartupName)
                .Index(t => t.CompanyName)
                .Index(t => t.RoomName);
            
            CreateTable(
                "dbo.Room",
                c => new
                    {
                        RoomName = c.String(nullable: false, maxLength: 128),
                        Floor = c.String(),
                    })
                .PrimaryKey(t => t.RoomName);
            
            CreateTable(
                "dbo.StartupM",
                c => new
                    {
                        StartupName = c.String(nullable: false, maxLength: 128),
                        PDFUrl = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.StartupName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meeting", "StartupName", "dbo.StartupM");
            DropForeignKey("dbo.Meeting", "RoomName", "dbo.Room");
            DropForeignKey("dbo.Meeting", "CompanyName", "dbo.Company");
            DropIndex("dbo.Meeting", new[] { "RoomName" });
            DropIndex("dbo.Meeting", new[] { "CompanyName" });
            DropIndex("dbo.Meeting", new[] { "StartupName" });
            DropTable("dbo.StartupM");
            DropTable("dbo.Room");
            DropTable("dbo.Meeting");
            DropTable("dbo.Company");
        }
    }
}
