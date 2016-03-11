/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace Cratis.Core.Assemblies
{
    /// <summary>
    /// Specifies what assemblies to include
    /// </summary>
    /// <remarks>
    /// Typically used by implementations of <see cref="IAssemblies"/> to 
    /// get the correct assemblies located for things like implementations of
    /// <see cref="ITypeDiscoverer"/> which relies on knowing about assemblies
    /// to be able to discover types.
    /// </remarks>
    public interface ICanSpecifyAssemblies
    {
        /// <summary>
        /// Method that gets called for specifying which assemblies to include or not
        /// </summary>
        /// <param name="builder"><see cref="IAssemblyRuleBuilder"/> object to build specification on</param>
        void Specify(IAssemblyRuleBuilder builder);
    }
}
