/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Cratis.Specifications;

namespace Cratis.Core.Assemblies
{
    /// <summary>
    /// Defines a rule builder for building configuration for assemblies and how to include
    /// or exclude assemblies
    /// </summary>
    public interface IAssemblyRuleBuilder
    {
        /// <summary>
        /// Get the specification to use
        /// </summary>
        Specification<string> Specification { get; set; }
    }
}
