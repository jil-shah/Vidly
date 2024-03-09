namespace Vidly.Migrations
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a1d3585-2c1e-4eb3-abaa-815f4a6c11c5', N'jilshah@hotmail.ca', 0, N'ADlqiyv70tSPT6Hx13GVmaK2VpFJnRFi1ptBz5GrqwyPYosdbHDefTNzYQw8ioV3QA==', N'1f4ef0c9-7161-4e7c-8065-486a83c45c4f', NULL, 0, 0, NULL, 1, 0, N'jilshah@hotmail.ca')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c6a1b32d-91f5-4113-b91d-dfcac7a631b6', N'test-vidly@email.com', 0, N'ABmsgyNT3U3pU350bQhULGtTnHfE5Uih5I0ZJnLJ8KtIlkJhS3ZLku1rNxFF7Nx0Bg==', N'916555a2-9c87-4568-9cc4-598ddf7621bf', NULL, 0, 0, NULL, 1, 0, N'test-vidly@email.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd976f228-6418-49aa-a75b-1697e34c3229', N'CanManageMovies')
            
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0a1d3585-2c1e-4eb3-abaa-815f4a6c11c5', N'd976f228-6418-49aa-a75b-1697e34c3229')

            ");
        }

        public override void Down()
        {
        }
    }
}
