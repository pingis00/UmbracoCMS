using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class ResponsiveMarginHelper
{
    public static string GetResponsiveMarginClasses(BlockGridItem model)
    {
        string GetMarginClass(string screenSize, string direction, string margin)
        {
            return margin?.ToLower() switch
            {
                "none" => $"m-{direction}-{screenSize}-none",
                "xs" => $"m-{direction}-{screenSize}-xs",
                "s" => $"m-{direction}-{screenSize}-s",
                "m" => $"m-{direction}-{screenSize}-m",
                "l" => $"m-{direction}-{screenSize}-l",
                "xl" => $"m-{direction}-{screenSize}-xl",
                "xxl" => $"m-{direction}-{screenSize}-xxl",
                _ => $"m-{direction}-{screenSize}-none"
            };
        }

        string GetMarginClassesForScreenSize(string screenSize, BlockGridItem model)
        {
            var marginTop = model?.Content.Value<string>($"{screenSize}ScreenMarginTop") ?? "none";
            var marginBottom = model?.Content.Value<string>($"{screenSize}ScreenMarginBottom") ?? "none";
            var marginLeft = model?.Content.Value<string>($"{screenSize}ScreenMarginLeft") ?? "none";
            var marginRight = model?.Content.Value<string>($"{screenSize}ScreenMarginRight") ?? "none";

            var marginTopClass = GetMarginClass(screenSize, "t", marginTop);
            var marginBottomClass = GetMarginClass(screenSize, "b", marginBottom);
            var marginLeftClass = GetMarginClass(screenSize, "l", marginLeft);
            var marginRightClass = GetMarginClass(screenSize, "r", marginRight);

            return $"{marginTopClass} {marginBottomClass} {marginLeftClass} {marginRightClass}";
        }

        var mobileMarginClasses = GetMarginClassesForScreenSize("mobile", model);
        var smallMarginClasses = GetMarginClassesForScreenSize("small", model);
        var mediumMarginClasses = GetMarginClassesForScreenSize("medium", model);
        var largeMarginClasses = GetMarginClassesForScreenSize("large", model);
        var xlMarginClasses = GetMarginClassesForScreenSize("xl", model);
        var xxlMarginClasses = GetMarginClassesForScreenSize("xxl", model);

        return $"{mobileMarginClasses} {smallMarginClasses} {mediumMarginClasses} {largeMarginClasses} {xlMarginClasses} {xxlMarginClasses}";
    }
}
