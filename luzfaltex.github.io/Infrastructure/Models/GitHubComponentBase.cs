using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components;

namespace luzfaltex.github.io.Infrastructure.Models;

public abstract class GitHubComponentBase : ComponentBase
{
    /// <summary>
    /// Gets the path to this file on disk.
    /// </summary>
    /// <param name="path">Provided by the compiler. Do not set.</param>
    /// <returns>The path to the source code for this file.</returns>
    public static string GetThisFilePath([CallerFilePath] string? path = null)
    {
        return path!;
    }
}