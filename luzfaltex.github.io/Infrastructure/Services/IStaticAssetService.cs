using System.Diagnostics.CodeAnalysis;

namespace luzfaltex.github.io.Infrastructure.Services;

/// <summary>
/// Provides a model for retrieving a static asset.
/// </summary>
public interface IStaticAssetService
{
    /// <summary>
    /// Gets the content of the asset at the provided <paramref name="assetUrl"/>.
    /// </summary>
    /// <param name="assetUrl">The url to use to access the asset.</param>
    /// <param name="useCache">A value indicating whether to use the cache.</param>
    /// <returns>The string contents of the specified asset.</returns>
    Task<string?> GetAsync([StringSyntax(StringSyntaxAttribute.Uri)] string assetUrl, bool useCache = true);
}