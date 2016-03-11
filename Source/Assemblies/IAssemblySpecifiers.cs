/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Reflection;

namespace Cratis.Core.Assemblies
{
    /// <summary>
    /// Defines a system that knows about <see cref="ICanSpecifyAssembly"/>
    /// </summary>
    public interface IAssemblySpecifiers
    {
        /// <summary>
        /// Specifies using specifiers found in a specific <see cref="Assembly"/>
        /// </summary>
        /// <param name="assembly"><see cref="Assembly"/> to find specifiers from</param>
        void SpecifyUsingSpecifiersFrom(Assembly assembly);
    }
}
