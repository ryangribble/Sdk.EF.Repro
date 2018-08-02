using System;
using Sdk.Ef.Repro.Lib;

namespace Sdk.EF.Repro.CmdLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var provider = new SqlProvider();

            Console.WriteLine($"Record: {provider.GetStringRecord()}");
        }
    }
}
