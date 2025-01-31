namespace luzfaltex.github.io.Components;

/// <summary>
/// Options for <see cref="MarkdownSectionPreCodeRenderer"/>.
/// </summary>
public sealed class MarkdownSectionPreCodeRendererOptions
{
    /// <summary>
    /// html attributes for Tag element in markdig generic attributes format
    /// </summary>
    public string? PreTagAttributes;

    /// <summary>
    /// html attributes for Code element in markdig generic attributes format
    /// </summary>
    public string? CodeTagAttributes;
}