namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Name) Values ('Jazz')");
            Sql("Insert into Genres (Name) Values ('Blues')");
            Sql("Insert into Genres (Name) Values ('Rock')");
            Sql("Insert into Genres (Name) Values ('Country')");
        }

        public override void Down()
        {
            Sql("Delete from Genres where Id in (1,2,3,4)");
        }
    }
}
