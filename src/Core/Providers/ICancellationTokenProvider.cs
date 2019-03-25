using Core.Framework;
using System.Threading;

namespace Core.Providers
{
    /// <summary>
    /// Provides Commands with a CancellationToken
    /// </summary>
    public interface ICancellationTokenProvider : IProvider<CancellationToken> { }
}
