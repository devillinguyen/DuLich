namespace DuLich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoachTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        SeatId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Seats", t => t.SeatId, cascadeDelete: true)
                .Index(t => t.SeatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coaches", "SeatId", "dbo.Seats");
            DropIndex("dbo.Coaches", new[] { "SeatId" });
            DropTable("dbo.Coaches");
        }
    }
}
