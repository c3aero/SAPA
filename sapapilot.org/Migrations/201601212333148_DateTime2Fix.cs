namespace SAPA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTime2Fix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "DOH", c => c.DateTime());
            AlterColumn("dbo.AspNetUsers", "BirthMonth", c => c.DateTime());
            AlterColumn("dbo.AspNetUsers", "SeniorityDate", c => c.DateTime());
            AlterColumn("dbo.AspNetUsers", "CheckrideDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "CheckrideDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "SeniorityDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "BirthMonth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "DOH", c => c.DateTime(nullable: false));
        }
    }
}
