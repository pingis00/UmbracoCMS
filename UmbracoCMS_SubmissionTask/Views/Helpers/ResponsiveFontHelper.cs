using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public static class ResponsiveFontHelper
{
    public static string GetResponsiveFontClasses(BlockGridItem? model, string element = "p")
    {
        if (model == null || model.Content == null)
        {
            return string.Empty;
        }

        bool useCustomFontSize = model?.Content.Value<bool>($"{element}UseCustomFontSize") ?? false;

        if (!useCustomFontSize)
        {
            return string.Empty;
        }

        string GetFontSizeClass(string screenSize, string fontSize)
        {
            return $"{element}-font-size-{screenSize}-{fontSize.ToLower()}";
        }

        string GetFontSizeValue(string screenSize, BlockGridItem model)
        {
            var value = model.Content.Value<string>($"{screenSize}ScreenFontSize") ?? "";
            var size = value.Split(' ')[0];
            return size.Equals("none", StringComparison.OrdinalIgnoreCase) ? "" : size;
        }

        string PropagateFontSize(string[] screenSizes, BlockGridItem model)
        {
            var fontSizeValues = new Dictionary<string, string>();
            string lastValue = "";

            foreach (var screenSize in screenSizes)
            {
                var fontSizeValue = GetFontSizeValue(screenSize, model);
                if (!string.IsNullOrEmpty(fontSizeValue))
                {
                    lastValue = fontSizeValue;
                }
                fontSizeValues[screenSize] = lastValue;
            }

            return string.Join(" ", screenSizes.Select(screenSize => GetFontSizeClass(screenSize, fontSizeValues[screenSize])));
        }

        var screenSizes = new[] { "mobile", "small", "medium", "large", "xl", "xxl" };

        return PropagateFontSize(screenSizes, model);
    }
}
