using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class MarginAutoHelper
{
    public static string GetMarginAutoClasses(BlockGridItem model)
    {
        var centerMobile = model?.Content.Value<bool>("mobileScreenCenter") ?? false;
        var centerSmall = model?.Content.Value<bool>("smallScreenCenter") ?? false;
        var centerMedium = model?.Content.Value<bool>("mediumScreenCenter") ?? false;
        var centerLarge = model?.Content.Value<bool>("largeScreenCenter") ?? false;
        var centerXL = model?.Content.Value<bool>("xlScreenCenter") ?? false;
        var centerXXL = model?.Content.Value<bool>("xxlScreenCenter") ?? false;

        return $@"
                {(centerMobile ? "m-mobile-auto" : "")}
                {(centerSmall ? "m-small-auto" : "")}
                {(centerMedium ? "m-medium-auto" : "")}
                {(centerLarge ? "m-large-auto" : "")}
                {(centerXL ? "m-xl-auto" : "")}
                {(centerXXL ? "m-xxl-auto" : "")}
            ".Trim();
    }
}
