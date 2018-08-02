using System;
using System.Data.Entity;
using System.Linq;
using Sdk.Ef.Repro.Lib;
using Sdk.Ef.Repro.Lib.Migrations;

namespace Sdk.EF.Repro.CmdLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestDBContext, Configuration>());
            using (var context = new TestDBContext())
            {
                context.Database.Initialize(force: true);
            }

            Console.WriteLine("Hello World!");

            var provider = new SqlProvider();

            Console.WriteLine($"Record: {provider.GetStringRecord()}");

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
