using System;
using System.IO;
using System.Reflection;
using Machine.Specifications.Runner.Core;

namespace Cratis.Core.Specifications
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AssemblyRunner.Run(typeof(Program).GetTypeInfo().Assembly);
        }
    }
}