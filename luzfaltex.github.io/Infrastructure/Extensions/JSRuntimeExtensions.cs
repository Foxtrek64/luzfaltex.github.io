using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace luzfaltex.github.io.Infrastructure.Extensions;

/// <summary>
/// Provides extensions for <see cref="IJSRuntime"/>.
/// </summary>
public static class JSRuntimeExtensions
{
    public static async Task<IJSObjectReference> ComponentModule<TModule>(this IJSRuntime jsRuntime)
        where TModule : ComponentBase
    {
        var result = await jsRuntime.InvokeAsync<IJSObjectReference>
        (
            identifier: "import",
            $"./Components/{typeof(TModule).Name}.razor.js"
        );
        return result;
    }
}