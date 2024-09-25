using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public static class ResponsiveFontHelper
{
    public static string GetResponsiveFontClasses(BlockGridItem model)
    {
        var mobileFontSize = model?.Content.Value<string[]>("mobileFontSize")?.FirstOrDefault()
                                ?? model?.Content.Value<string>("mobileFontSize")
                                ?? "M";

        var smallScreenFontSize = model?.Content.Value<string[]>("smallScreenFontSize")?.FirstOrDefault()
                                ?? model?.Content.Value<string>("smallScreenFontSize")
                                ?? "M";

        var mediumScreenFontSize = model?.Content.Value<string[]>("mediumScreenFontSize")?.FirstOrDefault()
                                 ?? model?.Content.Value<string>("mediumScreenFontSize")
                                 ?? "M";

        var largeScreenFontSize = model?.Content.Value<string[]>("largeScreenFontSize")?.FirstOrDefault()
                                ?? model?.Content.Value<string>("largeScreenFontSize")
                                ?? "M";

        var xlScreenFontSize = model?.Content.Value<string[]>("xlScreenFontSize")?.FirstOrDefault()
                             ?? model?.Content.Value<string>("xlScreenFontSize")
                             ?? "M";

        var xxlScreenFontSize = model?.Content.Value<string[]>("xxlScreenFontSize")?.FirstOrDefault()
                              ?? model?.Content.Value<string>("xxlScreenFontSize")
                              ?? "M";

        var mobileFontClass = $"font-size-xs-{mobileFontSize.ToLower()}";
        var smallScreenFontClass = $"font-size-sm-{smallScreenFontSize.ToLower()}";
        var mediumScreenFontClass = $"font-size-md-{mediumScreenFontSize.ToLower()}";
        var largeScreenFontClass = $"font-size-lg-{largeScreenFontSize.ToLower()}";
        var xlScreenFontClass = $"font-size-xl-{xlScreenFontSize.ToLower()}";
        var xxlScreenFontClass = $"font-size-xxl-{xxlScreenFontSize.ToLower()}";

        return $"{mobileFontClass} {smallScreenFontClass} {mediumScreenFontClass} {largeScreenFontClass} {xlScreenFontClass} {xxlScreenFontClass}";
    }
}
