using System.Data.Entity.Migrations;
using Sdk.Ef.Repro.Lib.Models;

namespace Sdk.Ef.Repro.Lib.Migrations
{
	public class Configuration : DbMigrationsConfiguration<TestDBContext>
	{
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(TestDBContext context)
        {
            base.Seed(context);

            context.StringRecords.Add(new StringRecord { RecordId = 1, Value = "foo" });
        }
    }
}
