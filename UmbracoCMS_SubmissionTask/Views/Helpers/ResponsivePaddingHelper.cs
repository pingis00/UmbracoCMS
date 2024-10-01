using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class ResponsivePaddingHelper
{
    public static string GetResponsivePaddingClasses(BlockGridItem model)
    {
        if (model == null || model.Content == null)
        {
            return string.Empty;
        }

        bool useCustomPadding = model?.Content.Value<bool>("useCustomPadding") ?? false;

        if (!useCustomPadding)
        {
            return string.Empty;
        }

        string GetPaddingClass(string screenSize, string direction, string padding)
        {
            if (string.IsNullOrEmpty(padding) || padding.Equals("none", StringComparison.OrdinalIgnoreCase))
                return string.Empty;

            return padding?.ToLower() switch
            {
                "xs" => $"p-{direction}-{screenSize}-xs",
                "s" => $"p-{direction}-{screenSize}-s",
                "m" => $"p-{direction}-{screenSize}-m",
                "l" => $"p-{direction}-{screenSize}-l",
                "xl" => $"p-{direction}-{screenSize}-xl",
                "xxl" => $"p-{direction}-{screenSize}-xxl",
                _ => string.Empty
            };
        }

        string GetPaddingValue(string screenSize, string direction, BlockGridItem model)
        {
            var value = model?.Content.Value<string>($"{screenSize}ScreenPadding{direction}") ?? "none";
            var size = value.Split(' ')[0];
            return size.Equals("none", StringComparison.OrdinalIgnoreCase) ? "" : size;
        }

        string PropagatePadding(string[] screenSizes, string direction, BlockGridItem model)
        {
            var paddingValues = new Dictionary<string, string>();
            string lastValue = "";

            foreach (var screenSize in screenSizes)
            {
                var paddingValue = GetPaddingValue(screenSize, direction, model);
                if (!string.IsNullOrEmpty(paddingValue))
                {
                    lastValue = paddingValue;
                }
                paddingValues[screenSize] = lastValue;
            }

            return string.Join(" ", screenSizes
                .Select(screenSize => GetPaddingClass(screenSize, direction.ToLower(), paddingValues[screenSize]))
                .Where(className => !string.IsNullOrEmpty(className)));
        }

        var screenSizes = new[] { "mobile", "small", "medium", "large", "xl", "xxl" };

        var paddingTopClasses = PropagatePadding(screenSizes, "Top", model!);
        var paddingBottomClasses = PropagatePadding(screenSizes, "Bottom", model!);
        var paddingLeftClasses = PropagatePadding(screenSizes, "Left", model!);
        var paddingRightClasses = PropagatePadding(screenSizes, "Right", model!);

        return $"{paddingTopClasses} {paddingBottomClasses} {paddingLeftClasses} {paddingRightClasses}";
    }
}

