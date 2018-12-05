namespace Bookly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Genres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Self-Help')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Science')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'English')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Bibliography')");
        }

        public override void Down()
        {
        }
    }
}