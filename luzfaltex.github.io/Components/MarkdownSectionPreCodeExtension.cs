using Markdig;
using Markdig.Renderers;
using Markdig.Renderers.Html;

namespace luzfaltex.github.io.Components;

public sealed class MarkdownSectionPreCodeExtension : IMarkdownExtension
{
    public void Setup(MarkdownPipelineBuilder pipeline)
    {
    }

    public void Setup(MarkdownPipeline pipeline, IMarkdownRenderer renderer)
    {
        if (renderer is not TextRendererBase<HtmlRenderer> htmlRenderer)
        {
            return;
        }

        if (htmlRenderer.ObjectRenderers.FindExact<CodeBlockRenderer>() is { } originalCodeBlockRenderer)
        {
            htmlRenderer.ObjectRenderers.Remove(originalCodeBlockRenderer);
        }

        htmlRenderer.ObjectRenderers.AddIfNotAlready(new MarkdownSectionPreCodeRenderer(
            new MarkdownSectionPreCodeRendererOptions { PreTagAttributes = "{.snippet .hljs-copy-wrapper}" }));
    }
}