/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using System.Reflection;
using Microsoft.DotNet.InternalAbstractions;
using Microsoft.Extensions.DependencyModel;

namespace Cratis.Core.Assemblies
{
    /// <summary>
    /// Represents an implementation of <see cref="IAssemblyProvider"/>
    /// </summary>
    public class AssemblyProvider : IAssemblyProvider
    {
#pragma warning disable 1591 // Xml Comments        
        public IEnumerable<AssemblyName> GetAllByName()
        {
            var assemblies = new List<Assembly>();
            
            var entryAssembly = Assembly.GetEntryAssembly();
            var dependencyModel = DependencyContext.Load(entryAssembly);
            var assemblyNames = dependencyModel.GetRuntimeAssemblyNames(RuntimeEnvironment.GetRuntimeIdentifier());
            return assemblyNames;
        }

        public Assembly Load(AssemblyName name)
        {
            return Assembly.Load(name);
        }
#pragma warning restore 1591 // Xml Comments        
    }
}