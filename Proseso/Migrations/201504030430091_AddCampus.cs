namespace Proseso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCampus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 6),
                        Name = c.String(nullable: false, maxLength: 50),
                        Details = c.String(maxLength: 150),
                        CreatedBy = c.String(),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedBy = c.String(),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Dropped = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Campus");
        }
    }
}
