using System;
using System.Collections.Generic;
using System.Reflection;

namespace Core.Utilities
{
    /// <summary>
    /// Scans assemblies and meta-data for bootstrapper processes
    /// </summary>
    public interface IAssemblyScanner
    {
        /// <summary>
        /// Gets all assemblies within the scope of the application
        /// </summary>
        /// <returns>All assemblies within the scope of the application</returns>
        IEnumerable<Assembly> GetApplicationAssemblies();

        /// <summary>
        /// Scans all Core assemblies and returns a collection of types that utilize a given attribute type and match the predicate argument
        /// </summary>
        /// <typeparam name="TAttribute">The attribute type to search all class in the assemblies for</typeparam>
        /// <returns>All Core types that utilize the given attribute type and match the predicate argument</returns>
        IEnumerable<Type> GetApplicationTypesWithAttribute<TAttribute>(params Assembly[] assemblies) where TAttribute : Attribute;

        /// <summary>
        /// Scans all Core assemblies and returns a collection of types that utilize a given attribute type and match the predicate argument
        /// </summary>
        /// <typeparam name="TAttribute">The attribute type to search all class in the assemblies for</typeparam>
        /// <param name="predicate">Optional; the condition of the types to match in order to include them in the return collection</param>
        /// <returns>All Core types that utilize the given attribute type and match the predicate argument</returns>
        IEnumerable<Type> GetApplicationTypesWithAttribute<TAttribute>(Func<TAttribute, bool> predicate, params Assembly[] assemblies) where TAttribute : Attribute;
    }
}
