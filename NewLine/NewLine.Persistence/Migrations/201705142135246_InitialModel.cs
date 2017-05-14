namespace NewLine.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evaluacions",
                c => new
                    {
                        EvaluacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EvaluacionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Evaluacions");
        }
    }
}
