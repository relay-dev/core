﻿using Core.Framework;
using System;

namespace Core.Providers
{
    /// <summary>
    /// Provides Commands with a random GUID
    /// </summary>
    public interface IRandomGuidProvider : IProvider<Guid> { }
}
