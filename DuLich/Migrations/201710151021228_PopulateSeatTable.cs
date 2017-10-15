namespace DuLich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSeatTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Seats(Id, Name) values(1, '4 cho ngoi')");
            Sql("insert into Seats(Id, Name) values(2, '7 cho ngoi')");
            Sql("insert into Seats(Id, Name) values(3, '14 cho ngoi')");
            Sql("insert into Seats(Id, Name) values(4, '30 cho ngoi')");
            Sql("insert into Seats(Id, Name) values(5, '50 cho ngoi')");
        }
        
        public override void Down()
        {
        }
    }
}
