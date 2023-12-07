namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdaysInCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1990-01-01' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
