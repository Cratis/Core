/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace Cratis.Core.Assemblies.Rules
{
    /// <summary>
    /// Represents a builder for building configuration used by <see cref="Assemblies"/>
    /// </summary>
    public class AssembliesConfigurationBuilder
    {
        /// <summary>
        /// Gets the <see cref="IAssemblyRuleBuilder">rule builder</see> used
        /// </summary>
        public IAssemblyRuleBuilder RuleBuilder { get; private set; }


        /// <summary>
        /// Include all assemblies with possible exceptions
        /// </summary>
        /// <returns>
        /// Returns the <see cref="IncludeAll">configuration object</see> for the rule
        /// </returns>
        public IncludeAll IncludeAll()
        {
            var includeAll = new IncludeAll();
            RuleBuilder = includeAll;
            return includeAll;
        }
    }
}
