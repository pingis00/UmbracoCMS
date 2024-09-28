using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class WidthHelper
{
    public static string GetResponsiveWidth(BlockGridItem? model)
    {

        bool useResponsiveWidth = model?.Content.Value<bool>("useResponsiveWidth") ?? false;

        if (!useResponsiveWidth)
        {
            return string.Empty;
        }

        string GetWidthClass(string screenSize, string width)
        {
            return $"width-{screenSize}-{width.Replace("%", "").ToLower()}";
        }

        string GetWidthValue(string screenSize, BlockGridItem model)
        {
            var value = model.Content.Value<string>($"{screenSize}Screen") ?? "";
            return value.Equals("none", StringComparison.OrdinalIgnoreCase) ? "" : value;
        }

        string PropagateWidth(string[] screenSizes, BlockGridItem model)
        {
            var widthValues = new Dictionary<string, string>();
            string lastValue = "";

            foreach (var screenSize in screenSizes)
            {
                var widthValue = GetWidthValue(screenSize, model);
                if (!string.IsNullOrEmpty(widthValue))
                {
                    lastValue = widthValue;
                }
                widthValues[screenSize] = lastValue;
            }

            return string.Join(" ", screenSizes.Select(screenSize => GetWidthClass(screenSize, widthValues[screenSize])));
        }

        var screenSizes = new[] { "mobile", "small", "medium", "large", "xl", "xxl" };

        return PropagateWidth(screenSizes, model!);
    }
}
