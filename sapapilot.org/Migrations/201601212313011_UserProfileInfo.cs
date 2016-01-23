namespace SAPA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserProfileInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "EmployeeID", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Seniority", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "DOH", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "VotingCode", c => c.String());
            AddColumn("dbo.AspNetUsers", "Domicile", c => c.String());
            AddColumn("dbo.AspNetUsers", "Position", c => c.String());
            AddColumn("dbo.AspNetUsers", "Fleet", c => c.String());
            AddColumn("dbo.AspNetUsers", "BirthMonth", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "SeniorityDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "CheckrideDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CheckrideDate");
            DropColumn("dbo.AspNetUsers", "SeniorityDate");
            DropColumn("dbo.AspNetUsers", "BirthMonth");
            DropColumn("dbo.AspNetUsers", "Fleet");
            DropColumn("dbo.AspNetUsers", "Position");
            DropColumn("dbo.AspNetUsers", "Domicile");
            DropColumn("dbo.AspNetUsers", "VotingCode");
            DropColumn("dbo.AspNetUsers", "DOH");
            DropColumn("dbo.AspNetUsers", "Seniority");
            DropColumn("dbo.AspNetUsers", "EmployeeID");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
