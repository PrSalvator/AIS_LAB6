namespace AIS_LAB6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDirectionsOfTrainingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TPUDirectionsOfTraining",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 8),
                        Name = c.String(nullable: false),
                        SchoolId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TPUSchools", t => t.SchoolId)
                .Index(t => t.SchoolId);
            
            AlterColumn("dbo.TPUSchools", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.TPUSchools", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.TPUSchools", "Tel", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TPUDirectionsOfTraining", "SchoolId", "dbo.TPUSchools");
            DropIndex("dbo.TPUDirectionsOfTraining", new[] { "SchoolId" });
            AlterColumn("dbo.TPUSchools", "Tel", c => c.String());
            AlterColumn("dbo.TPUSchools", "Address", c => c.String());
            AlterColumn("dbo.TPUSchools", "Name", c => c.String());
            DropTable("dbo.TPUDirectionsOfTraining");
        }
    }
}
