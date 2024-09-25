using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class ResponsivePaddingHelper
{
    public static string GetResponsivePaddingClasses(BlockGridItem model)
    {
        string GetPaddingClass(string screenSize, string direction, string padding)
        {
            return padding?.ToLower() switch
            {
                "none" => $"p-{direction}-{screenSize}-none",
                "xs" => $"p-{direction}-{screenSize}-xs",
                "s" => $"p-{direction}-{screenSize}-s",
                "m" => $"p-{direction}-{screenSize}-m",
                "l" => $"p-{direction}-{screenSize}-l",
                "xl" => $"p-{direction}-{screenSize}-xl",
                "xxl" => $"p-{direction}-{screenSize}-xxl",
                _ => $"p-{direction}-{screenSize}-none"
            };
        }

        string GetPaddingClassesForScreenSize(string screenSize, BlockGridItem model)
        {
            var paddingTop = model?.Content.Value<string>($"{screenSize}ScreenPaddingTop") ?? "none";
            var paddingBottom = model?.Content.Value<string>($"{screenSize}ScreenPaddingBottom") ?? "none";
            var paddingLeft = model?.Content.Value<string>($"{screenSize}ScreenPaddingLeft") ?? "none";
            var paddingRight = model?.Content.Value<string>($"{screenSize}ScreenPaddingRight") ?? "none";

            var paddingTopClass = GetPaddingClass(screenSize, "t", paddingTop);
            var paddingBottomClass = GetPaddingClass(screenSize, "b", paddingBottom);
            var paddingLeftClass = GetPaddingClass(screenSize, "l", paddingLeft);
            var paddingRightClass = GetPaddingClass(screenSize, "r", paddingRight);

            return $"{paddingTopClass} {paddingBottomClass} {paddingLeftClass} {paddingRightClass}";
        }

        var mobilePaddingClasses = GetPaddingClassesForScreenSize("mobile", model);
        var smallPaddingClasses = GetPaddingClassesForScreenSize("small", model);
        var mediumPaddingClasses = GetPaddingClassesForScreenSize("medium", model);
        var largePaddingClasses = GetPaddingClassesForScreenSize("large", model);
        var xlPaddingClasses = GetPaddingClassesForScreenSize("xl", model);
        var xxlPaddingClasses = GetPaddingClassesForScreenSize("xxl", model);

        return $"{mobilePaddingClasses} {smallPaddingClasses} {mediumPaddingClasses} {largePaddingClasses} {xlPaddingClasses} {xxlPaddingClasses}";
    }
}

