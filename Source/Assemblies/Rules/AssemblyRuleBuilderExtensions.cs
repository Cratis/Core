/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Cratis.Core.Specifications;

namespace Cratis.Core.Assemblies.Rules
{
    /// <summary>
    /// Provides extensions for <see cref="IAssemblyRuleBuilder"/>
    /// </summary>
    public static class AssemblyRuleBuilderExtensions
    {

        /// <summary>
        /// Excludes specified assemblies
        /// </summary>
        /// <param name="assemblyBuilder"><see cref="IAssemblyBuilder"/> to build upon</param>
        /// <param name="names">Names that assemblies should not be starting with</param>
        /// <returns>Chained <see cref="IAssemblyBuilder"/></returns>
        public static IAssemblyRuleBuilder ExcludeAssembliesStartingWith(this IAssemblyRuleBuilder assemblyBuilder, params string[] names)
        {
            assemblyBuilder.Specification = assemblyBuilder.Specification.And(new ExceptAssembliesStartingWith(names));
            return assemblyBuilder;
        }
    }
}
