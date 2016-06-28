/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using System.Reflection;

namespace Cratis.Core.Assemblies
{
    /// <summary>
    /// Defines a system that can provide <see cref="Assembly">assemblies</see>
    /// </summary>
    public interface IAssemblyProvider
    {
        /// <summary>
        /// Get all available  <see cref="Assembly">assemblies</see>
        /// </summary>
        IEnumerable<AssemblyName> GetAllByName();
        
        /// <summary>
        /// Load assembly by its name
        /// </summary>
        Assembly Load(AssemblyName name);
    }
}
