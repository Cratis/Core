/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Einar Ingebrigtsen. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace Cratis.Core.Execution
{
    /// <summary>
    /// Indicates that a class is Singleton and should be treated as such
    /// for any factory creating an instance of a class marked with this
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SingletonAttribute : Attribute
    {
    }
}
