using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class ResponsiveTextAlignHelper
{
    public static string GetResponsiveTextAlign(BlockGridItem model)
    {
        var mobileScreenTextAlign = model?.Content.Value<string[]>("mobileScreenTextAlign")?.FirstOrDefault()
                    ?? model?.Content.Value<string>("mobileScreenTextAlign")
                    ?? "center";

        var smallScreenTextAlign = model?.Content.Value<string[]>("smallScreenTextAlign")?.FirstOrDefault()
                                ?? model?.Content.Value<string>("smallScreenTextAlign")
                                ?? "left";

        var mediumScreenTextAlign = model?.Content.Value<string[]>("mediumScreenTextAlign")?.FirstOrDefault()
                                 ?? model?.Content.Value<string>("mediumScreenTextAlign")
                                 ?? "left";

        var largeScreenTextAlign = model?.Content.Value<string[]>("largeScreenTextAlign")?.FirstOrDefault()
                                ?? model?.Content.Value<string>("largeScreenTextAlign")
                                ?? "left";

        var xlScreenTextAlign = model?.Content.Value<string[]>("xlScreenTextAlign")?.FirstOrDefault()
                             ?? model?.Content.Value<string>("xlScreenTextAlign")
                             ?? "left";

        var xxlScreenTextAlign = model?.Content.Value<string[]>("xxlScreenTextAlign")?.FirstOrDefault()
                              ?? model?.Content.Value<string>("xxlScreenTextAlign")
                              ?? "left";

        var mobileScreenTextAlignClass = $"text-align-xs-{mobileScreenTextAlign.ToLower()}";
        var smallScreenTextAlignClass = $"text-align-sm-{smallScreenTextAlign.ToLower()}";
        var mediumScreenTextAlignClass = $"text-align-md-{mediumScreenTextAlign.ToLower()}";
        var largeScreenTextAlignClass = $"text-align-lg-{largeScreenTextAlign.ToLower()}";
        var xlScreenTextAlignClass = $"text-align-xl-{xlScreenTextAlign.ToLower()}";
        var xxlScreenTextAlignClass = $"text-align-xxl-{xxlScreenTextAlign.ToLower()}";

        return $"{mobileScreenTextAlignClass} {smallScreenTextAlignClass} {mediumScreenTextAlignClass} {largeScreenTextAlignClass} {xlScreenTextAlignClass} {xxlScreenTextAlignClass}";
    }
}
