﻿namespace GiaBao_2011061513.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowingsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Followings",
                c => new
                    {
                        FollowerId = c.String(nullable: false, maxLength: 128),
                        FolloweeId = c.String(nullable: false, maxLength: 128),
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FollowerId, t.FolloweeId })
                .ForeignKey("dbo.AspNetUsers", t => t.FollowerId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.FollowerId)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Followings", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "FollowerId", "dbo.AspNetUsers");
            DropIndex("dbo.Followings", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Followings", new[] { "FollowerId" });
            DropTable("dbo.Followings");
        }
    }
}
