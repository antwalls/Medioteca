namespace Medioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class production : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        file_ID = c.String(nullable: false, maxLength: 128),
                        file_Name = c.String(),
                        file_Path = c.String(),
                        file_kind = c.Int(nullable: false),
                        contentType = c.String(),
                    })
                .PrimaryKey(t => t.file_ID);
            
            CreateTable(
                "dbo.UserFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.String(),
                        file_ID = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserFiles");
            DropTable("dbo.Files");
        }
    }
}
