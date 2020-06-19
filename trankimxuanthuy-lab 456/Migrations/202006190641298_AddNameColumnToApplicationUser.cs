namespace trankimxuanthuy_lab_456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Followings",
                c => new
                    {
                        FollowerId = c.String(nullable: false, maxLength: 128),
                        FolloweeId = c.String(nullable: false, maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        ApplicationUser_Id1 = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FollowerId, t.FolloweeId })
                .ForeignKey("dbo.AspNetUsers", t => t.FollowerId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id1)
                .Index(t => t.FollowerId)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id1);
            
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Followings", "ApplicationUser_Id1", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "FollowerId", "dbo.AspNetUsers");
            DropIndex("dbo.Followings", new[] { "ApplicationUser_Id1" });
            DropIndex("dbo.Followings", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Followings", new[] { "FollowerId" });
            DropColumn("dbo.AspNetUsers", "Name");
            DropTable("dbo.Followings");
        }
    }
}
