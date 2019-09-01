namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changkey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.IdentityUserRoles");
            AlterColumn("dbo.IdentityUserRoles", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.IdentityUserRoles", new[] { "UserId", "RoleId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.IdentityUserRoles");
            AlterColumn("dbo.IdentityUserRoles", "UserId", c => c.String());
            AddPrimaryKey("dbo.IdentityUserRoles", "RoleId");
        }
    }
}
