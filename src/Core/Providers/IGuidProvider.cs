using Core.Framework;
using System;

namespace Core.Providers
{
    /// <summary>
    /// Provides Commands with a GUID
    /// </summary>
    public interface IGuidProvider : IProvider<Guid> { }
}
