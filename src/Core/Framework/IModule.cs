﻿namespace Core.Data
{
    /// <summary>
    /// An assortment of Components, usually culminating to an Aggregate Root in the system
    /// </summary>
    public interface IModule
    {
        /// <summary>
        /// Gets a Component that belongs to the Module
        /// </summary>
        /// <typeparam name="IComponent">Component type to be returned</typeparam>
        /// <returns>A new instance of an object of type IComponent</returns>
        IComponent GetComponent<IComponent>();
    }
}