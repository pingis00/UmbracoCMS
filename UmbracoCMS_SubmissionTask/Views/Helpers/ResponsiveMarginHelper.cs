using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class ResponsiveMarginHelper
{
    public static string GetResponsiveMarginClasses(BlockGridItem model)
    {
        string GetMarginClass(string screenSize, string direction, string margin)
        {
            if (model == null || model.Content == null)
            {
                return string.Empty;
            }

            bool useCustomMargins = model?.Content.Value<bool>("useCustomMargins") ?? false;

            if (!useCustomMargins)
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(margin) || margin.Equals("none", StringComparison.OrdinalIgnoreCase))
                return string.Empty;

            return margin?.ToLower() switch
            {
                "xs" => $"m-{direction}-{screenSize}-xs",
                "s" => $"m-{direction}-{screenSize}-s",
                "m" => $"m-{direction}-{screenSize}-m",
                "l" => $"m-{direction}-{screenSize}-l",
                "xl" => $"m-{direction}-{screenSize}-xl",
                "xxl" => $"m-{direction}-{screenSize}-xxl",
                _ => string.Empty
            };
        }

        string GetMarginValue(string screenSize, string direction, BlockGridItem model)
        {
            var value = model?.Content.Value<string>($"{screenSize}ScreenMargin{direction}") ?? "none";
            var size = value.Split(' ')[0];
            return size.Equals("none", StringComparison.OrdinalIgnoreCase) ? "" : size;
        }

        string PropagateMargin(string[] screenSizes, string direction, BlockGridItem model)
        {
            var marginValues = new Dictionary<string, string>();
            string lastValue = "";

            foreach (var screenSize in screenSizes)
            {
                var marginValue = GetMarginValue(screenSize, direction, model);
                if (!string.IsNullOrEmpty(marginValue))
                {
                    lastValue = marginValue;
                }
                marginValues[screenSize] = lastValue;
            }

            return string.Join(" ", screenSizes
                .Select(screenSize => GetMarginClass(screenSize, direction.ToLower(), marginValues[screenSize]))
                .Where(className => !string.IsNullOrEmpty(className)));
        }

        var screenSizes = new[] { "mobile", "small", "medium", "large", "xl", "xxl" };

        var marginTopClasses = PropagateMargin(screenSizes, "Top", model);
        var marginBottomClasses = PropagateMargin(screenSizes, "Bottom", model);
        var marginLeftClasses = PropagateMargin(screenSizes, "Left", model);
        var marginRightClasses = PropagateMargin(screenSizes, "Right", model);

        return $"{marginTopClasses} {marginBottomClasses} {marginLeftClasses} {marginRightClasses}";
    }
}
