namespace MVC5UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAccount : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Account", "Username", c => c.String(nullable: false, maxLength: 16));
            AlterColumn("dbo.Account", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Account", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Account", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Account", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Account", "Cellphone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Account", "Cellphone", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Account", "Phone", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Account", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Account", "Email", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Account", "Password", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Account", "Username", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
