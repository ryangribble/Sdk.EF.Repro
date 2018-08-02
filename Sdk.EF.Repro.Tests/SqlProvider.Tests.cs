using System;
using Sdk.Ef.Repro.Lib;
using Xunit;

namespace Sdk.EF.Repro.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetStringRecordReturnsFoo()
        {
            var fixture = new SqlProvider();

            var result = fixture.GetStringRecord();

            Assert.Equal("foo", result);
        }
    }
}
