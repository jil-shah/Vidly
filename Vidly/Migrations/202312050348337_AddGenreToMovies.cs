namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreToMovies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberInStock = c.Byte(nullable: false),
                        GenreId_Id = c.Byte(),
                        GenreName_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Genres", t => t.GenreId_Id)
                .ForeignKey("dbo.Genres", t => t.GenreName_Id)
                .Index(t => t.GenreId_Id)
                .Index(t => t.GenreName_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreName_Id", "dbo.Genres");
            DropForeignKey("dbo.Movies", "GenreId_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreName_Id" });
            DropIndex("dbo.Movies", new[] { "GenreId_Id" });
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
        }
    }
}
