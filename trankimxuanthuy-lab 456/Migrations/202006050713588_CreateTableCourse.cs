namespace trankimxuanthuy_lab_456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 225),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeturerId = c.String(nullable: false, maxLength: 128),
                        Place = c.String(nullable: false, maxLength: 225),
                        Datetime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.LeturerId, cascadeDelete: true)
                .Index(t => t.LeturerId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "LeturerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            DropIndex("dbo.Courses", new[] { "LeturerId" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
