using System;
using System.Reflection;
using Cratis.Core.Assemblies;
using Machine.Specifications.Runner.Core;

namespace Cratis.Core.Specifications
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ap = new AssemblyProvider();
            var a = ap.GetAll();
            
            foreach( var assembly in a ) Console.WriteLine($"Assembly '{assembly.FullName}'"); 
            
            
            
            //AssemblyRunner.Run(typeof(Program).GetTypeInfo().Assembly);
        }
    }
}