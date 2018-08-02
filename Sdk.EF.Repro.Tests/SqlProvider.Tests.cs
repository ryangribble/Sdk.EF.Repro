using System;
using System.Data.Entity;
using System.Linq;
using Sdk.Ef.Repro.Lib;
using Sdk.Ef.Repro.Lib.Migrations;
using Xunit;

namespace Sdk.EF.Repro.Tests
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestDBContext, Configuration>());

            using (var context = new TestDBContext())
            {
                if (context.Database.Exists())
                {
                    var sqlCommand = String.Format("ALTER DATABASE {0} SET SINGLE_USER WITH ROLLBACK IMMEDIATE", "TestDB_Testing");
                    context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCommand);
                }

                //Drop and re-create the database each test run.
                context.Database.Delete();

                //Ensure the seed gets performed.
                var count = context.StringRecords.Count();
            }
        }

        [Fact]
        public void GetStringRecordReturnsFoo()
        {
            var fixture = new SqlProvider();

            var result = fixture.GetStringRecord();

            Assert.Equal("foo", result);
        }
        
        [Fact]
        public void GetIntRecordReturnsOne()
        {
            var fixture = new SqlProvider();

            var result = fixture.GetIntRecord();

            Assert.Equal(1, result);
        }
    }
}
