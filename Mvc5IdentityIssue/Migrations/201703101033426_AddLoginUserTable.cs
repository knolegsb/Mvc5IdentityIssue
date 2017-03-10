namespace Mvc5IdentityIssue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLoginUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoginUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FullName = c.String(),
                        Email = c.String(),
                        Gender = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoginUsers");
        }
    }
}
