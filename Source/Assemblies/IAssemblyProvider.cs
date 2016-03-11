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
        /// Get all the <see cref="_Assembly">assemblies</see> that can be provided
        /// </summary>
        /// <returns><see cref="IEnumerable{Assembly}">Assemblies</see> provided</returns>
        IEnumerable<Assembly> GetAll();
    }
}
