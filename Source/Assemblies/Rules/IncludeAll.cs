/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Cratis.Specifications;

namespace Cratis.Core.Assemblies.Rules
{
    /// <summary>
    /// Represents the <see cref="IAssemblyRuleBuilder">builder</see> for building the <see cref="IncludeAllRule"/> and
    /// possible exceptions
    /// </summary>
    public class IncludeAll : IAssemblyRuleBuilder
    {
        /// <summary>
        /// Initializes an instance of <see cref="IncludeAll"/>
        /// </summary>
        public IncludeAll()
        {
            Specification = new IncludeAllRule();
        }

        /// <summary>
        /// Gets the <see cref="IncludeAllRule"/>
        /// </summary>
        public Specification<string> Specification { get; set; }
    }
}
