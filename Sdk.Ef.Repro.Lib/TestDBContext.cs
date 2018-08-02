using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdk.Ef.Repro.Lib.Migrations;
using Sdk.Ef.Repro.Lib.Models;

namespace Sdk.Ef.Repro.Lib
{
    public class TestDBContext : DbContext
    {
        public TestDBContext()
            : base("TestDBContext")
        {
        }

        public DbSet<StringRecord> StringRecords { get; set; }
    }
}
