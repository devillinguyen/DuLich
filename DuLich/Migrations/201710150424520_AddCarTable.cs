namespace DuLich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Image", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Image");
        }
    }
}
