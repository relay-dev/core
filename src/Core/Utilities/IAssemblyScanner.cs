﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace Core.Utilities
{
    /// <summary>
    /// Scans assemblies and metadata for bootstrapper processes
    /// </summary>
    public interface IAssemblyScanner
    {
        /// <summary>
        /// Scans assemblies and returns a collection of types that utilize a given attribute type and match an optional predicate argument if specified
        /// </summary>
        /// <typeparam name="TAttribute">The attribute type to search all class in the assemblies for</typeparam>
        /// <param name="assemblies">The assemblies to scan</param>
        /// <param name="predicate">Optional; the condition of the types to match in order to include them in the return collection</param>
        /// <returns>All types that utilize the given attribute type and match the predicate argument</returns>
        IEnumerable<Type> FindTypesWithAttribute<TAttribute>(IEnumerable<Assembly> assemblies, Func<TAttribute, bool> predicate = null) where TAttribute : Attribute;

        /// <summary>
        /// Scans assemblies and returns a collection of types that utilize a given attribute type and match an optional predicate argument if specified
        /// </summary>
        /// <param name="type">The attribute type to search all class in the assemblies for</param>
        /// <param name="assemblies">The assemblies to scan</param>
        /// <param name="predicate">Optional; the condition of the types to match in order to include them in the return collection</param>
        /// <returns>All types that utilize the given attribute type and match the predicate argument</returns>
        IEnumerable<Type> FindTypesWithAttribute(Type type, IEnumerable<Assembly> assemblies, Func<object, bool> predicate = null);

        /// <summary>
        /// Scans assemblies and returns a collection of types that utilize a given attribute type and match an optional predicate argument if specified
        /// </summary>
        /// <typeparam name="TBaseClass">The base class to search all class in the assemblies for</typeparam>
        /// <param name="assemblies">The assemblies to scan</param>
        /// <param name="predicate">Optional; the condition of the types to match in order to include them in the return collection</param>
        /// <returns>All types that utilize the given attribute type and match the predicate argument</returns>
        IEnumerable<Type> FindTypesWithBaseClass<TBaseClass>(IEnumerable<Assembly> assemblies, Func<Type, bool> predicate = null);

        /// <summary>
        /// Scans assemblies and returns a collection of types that utilize a given attribute type and match an optional predicate argument if specified
        /// </summary>
        /// <param name="type">The base class to search all class in the assemblies for</param>
        /// <param name="assemblies">The assemblies to scan</param>
        /// <param name="predicate">Optional; the condition of the types to match in order to include them in the return collection</param>
        /// <returns>All types that utilize the given attribute type and match the predicate argument</returns>
        IEnumerable<Type> FindTypesWithBaseClass(Type type, IEnumerable<Assembly> assemblies, Func<Type, bool> predicate = null);

        /// <summary>
        /// Scans assemblies and returns a collection of types that utilize a given attribute type and match an optional predicate argument if specified
        /// </summary>
        /// <typeparam name="TInterface">The interface to search all class in the assemblies for</typeparam>
        /// <param name="assemblies">The assemblies to scan</param>
        /// <param name="predicate">Optional; the condition of the types to match in order to include them in the return collection</param>
        /// <returns>All types that utilize the given attribute type and match the predicate argument</returns>
        IEnumerable<Type> FindTypesWithInterface<TInterface>(IEnumerable<Assembly> assemblies, Func<Type, bool> predicate = null);

        /// <summary>
        /// Scans assemblies and returns a collection of types that utilize a given attribute type and match an optional predicate argument if specified
        /// </summary>
        /// <param name="type">The interface to search all class in the assemblies for</param>
        /// <param name="assemblies">The assemblies to scan</param>
        /// <param name="predicate">Optional; the condition of the types to match in order to include them in the return collection</param>
        /// <returns>All types that utilize the given attribute type and match the predicate argument</returns>
        IEnumerable<Type> FindTypesWithInterface(Type type, IEnumerable<Assembly> assemblies, Func<Type, bool> predicate = null);

        /// <summary>
        /// Gets all assemblies within the scope of the application
        /// </summary>
        /// <returns>All assemblies within the scope of the application</returns>
        IEnumerable<Assembly> GetApplicationAssemblies();
    }
}
