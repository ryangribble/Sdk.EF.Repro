﻿using System;
using System.Linq;

namespace Sdk.Ef.Repro.Lib
{
    public class SqlProvider
    {
        public string GetStringRecord()
        {
            using (var db = new TestDBContext())
            {
                return db.StringRecords.First().Value;
            }
        }
    }
}
