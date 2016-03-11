/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Cratis.Core.Specifications;

namespace Cratis.Core.Assemblies.Rules
{
    /// <summary>
    /// Represents the configuration for Assemblies
    /// </summary>
    public class AssembliesConfiguration
    {
        IAssemblyRuleBuilder _assemblyRuleBuilder;

        /// <summary>
        /// Initializes a new instance of <see cref="AssembliesConfiguration"/>
        /// </summary>
        /// <param name="assemblyRuleBuilder"><see cref="IAssemblyRuleBuilder"/> that builds the rules</param>
        public AssembliesConfiguration(IAssemblyRuleBuilder assemblyRuleBuilder)
        {
            _assemblyRuleBuilder = assemblyRuleBuilder;
        }

        /// <summary>
        /// Gets the specification used to specifying which assemblies to include
        /// </summary>
        public Specification<string> Specification { get { return _assemblyRuleBuilder.Specification; } }
    }
}
