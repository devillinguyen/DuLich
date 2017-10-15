namespace DuLich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSeatTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Seats(Id, Name) values(1, '7 Cho Ngoi')");
            Sql("insert into Seats(Id, Name) values(2, '14 Cho Ngoi')");
            Sql("insert into Seats(Id, Name) values(3, '30 Cho Ngoi')");
            Sql("insert into Seats(Id, Name) values(4, '50 Cho Ngoi')");
        }
        
        public override void Down()
        {
        }
    }
}
