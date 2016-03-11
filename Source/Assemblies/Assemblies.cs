/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cratis.Core.Execution;

namespace Cratis.Core.Assemblies
{
    /// <summary>
    /// Represents a <see cref="IAssemblies"/>
    /// </summary>
    [Singleton]
    public class Assemblies : IAssemblies
    {
        IAssemblyProvider _assemblyProvider;
        IEnumerable<Assembly> _assemblies;

        /// <summary>
        /// Initializes a new instance of <see cref="Assemblies"/>
        /// </summary>
        public Assemblies(IAssemblyProvider assemblyProvider)
        {
            _assemblyProvider = assemblyProvider;
            _assemblies = assemblyProvider.GetAll();
        }

#pragma warning disable 1591 // Xml Comments
        public IEnumerable<Assembly> GetAll()
        {
            return _assemblies;
        }

        public Assembly GetByFullName(string fullName)
        {
            var query = from a in _assemblies
                        where a.FullName == fullName
                        select a;

            var assembly = query.SingleOrDefault();
            return assembly;
        }

        public Assembly GetByName(string name)
        {
            var query = from a in _assemblies
                        where a.FullName.Contains(name)
                        select a;

            var assembly = query.SingleOrDefault();
            return assembly;
        }
#pragma warning restore 1591 // Xml Comments
    }
}
