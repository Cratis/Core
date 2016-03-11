/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace Cratis.Core.Assemblies
{
    /// <summary>
    /// Defines a system for filtering assemblies
    /// </summary>
    public interface IAssemblyFilters
    {
        /// <summary>
        /// Method that decides wether or not an assembly should be included
        /// </summary>
        /// <param name="filename">Filename of assembly to ask for</param>
        /// <returns>True if it should be included, false if not</returns>
        bool ShouldInclude(string filename);
    }
}
