namespace DuLich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        SeatId = c.Byte(nullable: false),
                        Color = c.String(nullable: false, maxLength: 50),
                        Brand = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Inventory = c.Int(nullable: false),
                        Image = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Seats", t => t.SeatId, cascadeDelete: true)
                .Index(t => t.SeatId);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "SeatId", "dbo.Seats");
            DropIndex("dbo.Cars", new[] { "SeatId" });
            DropColumn("dbo.AspNetUsers", "Name");
            DropTable("dbo.Seats");
            DropTable("dbo.Cars");
        }
    }
}
