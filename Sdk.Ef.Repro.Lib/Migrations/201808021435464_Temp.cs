namespace Sdk.Ef.Repro.Lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Temp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IntRecords",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordId);

            SqlResource("Sdk.Ef.Repro.Lib.Migrations.201808021435464_Temp_go.sql");
        }

        public override void Down()
        {
            DropTable("dbo.IntRecords");
        }
    }
}
