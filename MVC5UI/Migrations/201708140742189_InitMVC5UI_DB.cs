namespace MVC5UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMVC5UI_DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        Name = c.String(nullable: false, maxLength: 255),
                        Phone = c.String(nullable: false, maxLength: 255),
                        Cellphone = c.String(nullable: false, maxLength: 255),
                        RoleId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Account_Log",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        AType = c.String(nullable: false, maxLength: 6),
                        Id = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        Name = c.String(nullable: false, maxLength: 255),
                        Phone = c.String(nullable: false, maxLength: 255),
                        Cellphone = c.String(nullable: false, maxLength: 255),
                        RoleId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        LogTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LogId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Role_Log",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        AType = c.String(nullable: false, maxLength: 6),
                        Id = c.Int(nullable: false),
                        RoleName = c.String(nullable: false, maxLength: 255),
                        LogTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LogId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusName = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status_Log",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        AType = c.String(nullable: false, maxLength: 6),
                        Id = c.Int(nullable: false),
                        StatusName = c.String(nullable: false, maxLength: 255),
                        LogTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LogId);

            //Trigger

            string stringAccount = @"USE [MVC5UI]
                                    GO
                                    SET ANSI_NULLS ON
                                    GO
                                    SET QUOTED_IDENTIFIER ON
                                    GO
                                    CREATE TRIGGER [TR_Account_Modify] on [dbo].[Account] AFTER UPDATE,INSERT,DELETE
                                    AS
                                    BEGIN 
                                        IF EXISTS (select 1 from inserted) and EXISTS (select 1 from deleted)
                                        BEGIN     
                                            insert into Account_Log select 'UPDATE' as AType,*,GETDATE() as LogTime from inserted
                                        END
                                        ELSE IF EXISTS (select 1 from inserted) and Not EXISTS (select 1 from deleted)
                                            insert into Account_Log select 'INSERT' as AType,*,GETDATE() as LogTime from inserted
                                        ELSE IF NOT EXISTS (select 1 from inserted) and EXISTS (select 1 from deleted)
                                            insert into Account_Log select 'DELETE' as AType,*,GETDATE() as LogTime from deleted
 
                                    END";
            Sql(stringAccount);


            string stringRole = @"USE [MVC5UI]
                                    GO
                                    SET ANSI_NULLS ON
                                    GO
                                    SET QUOTED_IDENTIFIER ON
                                    GO
                                    CREATE TRIGGER [TR_Role_Modify] on [dbo].[Role] AFTER UPDATE,INSERT,DELETE
                                    AS
                                    BEGIN 
                                        IF EXISTS (select 1 from inserted) and EXISTS (select 1 from deleted)
                                        BEGIN     
                                            insert into Role_Log select 'UPDATE' as AType,*,GETDATE() as LogTime from inserted
                                        END
                                        ELSE IF EXISTS (select 1 from inserted) and Not EXISTS (select 1 from deleted)
                                            insert into Role_Log select 'INSERT' as AType,*,GETDATE() as LogTime from inserted
                                        ELSE IF NOT EXISTS (select 1 from inserted) and EXISTS (select 1 from deleted)
                                            insert into Role_Log select 'DELETE' as AType,*,GETDATE() as LogTime from deleted
 
                                    END";
            Sql(stringRole);

            string stringStatus = @"USE [MVC5UI]
                                    GO
                                    SET ANSI_NULLS ON
                                    GO
                                    SET QUOTED_IDENTIFIER ON
                                    GO
                                    CREATE TRIGGER [TR_Status_Modify] on [dbo].[Status] AFTER UPDATE,INSERT,DELETE
                                    AS
                                    BEGIN 
                                        IF EXISTS (select 1 from inserted) and EXISTS (select 1 from deleted)
                                        BEGIN     
                                            insert into Status_Log select 'UPDATE' as AType,*,GETDATE() as LogTime from inserted
                                        END
                                        ELSE IF EXISTS (select 1 from inserted) and Not EXISTS (select 1 from deleted)
                                            insert into Status_Log select 'INSERT' as AType,*,GETDATE() as LogTime from inserted
                                        ELSE IF NOT EXISTS (select 1 from inserted) and EXISTS (select 1 from deleted)
                                            insert into Status_Log select 'DELETE' as AType,*,GETDATE() as LogTime from deleted
 
                                    END";
            Sql(stringStatus);
        }
        
        public override void Down()
        {
            DropTable("dbo.Status_Log");
            DropTable("dbo.Status");
            DropTable("dbo.Role_Log");
            DropTable("dbo.Role");
            DropTable("dbo.Account_Log");
            DropTable("dbo.Account");

            Sql("DROP TRIGGER [TR_Account_Modify]");
            Sql("DROP TRIGGER [TR_Role_Modify]");
            Sql("DROP TRIGGER [TR_Status_Modify]");
        }
    }
}
