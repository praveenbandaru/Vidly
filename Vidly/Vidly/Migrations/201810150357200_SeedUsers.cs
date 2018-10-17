namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8cfb5a6f-bc9e-4286-ac43-358f7772dd16', N'guest@vidly.com', 0, N'AAhWHdg0+y9r5c+m5DGfpjsn2OWMJd994h/cSn/b4ZNDUaVNIfsiqDcHSuxADjvyZA==', N'16dcb8fc-82f6-4c4a-a1ad-74baca653dc1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bdd3f217-097c-4a07-bbbf-e72934044335', N'admin@vidly.com', 0, N'AL4RE0kXZuTD7Lx3NbskrwHwdqnklOhd/ItZXkryxwuSj+LwmfztSfe3THHCvKSaXw==', N'e59ef919-8e1c-4e89-b7c0-36f5bcff6e6c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fba9df6a-bf7b-4061-ba70-25df02e53d06', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bdd3f217-097c-4a07-bbbf-e72934044335', N'fba9df6a-bf7b-4061-ba70-25df02e53d06')

");
        }

        public override void Down()
        {
        }
    }
}
