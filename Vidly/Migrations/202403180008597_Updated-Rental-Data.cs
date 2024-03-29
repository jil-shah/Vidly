namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedRentalData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "Customer_Id", c => c.Int());
            AddColumn("dbo.Rentals", "Movie_Id", c => c.Int());
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
            CreateIndex("dbo.Rentals", "Customer_Id");
            CreateIndex("dbo.Rentals", "Movie_Id");
            AddForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers", "Id");
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id");
            DropColumn("dbo.Rentals", "CustomerId");
            DropColumn("dbo.Rentals", "MovieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "MovieId", c => c.Int(nullable: false));
            AddColumn("dbo.Rentals", "CustomerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "Movie_Id");
            DropColumn("dbo.Rentals", "Customer_Id");
        }
    }
}
