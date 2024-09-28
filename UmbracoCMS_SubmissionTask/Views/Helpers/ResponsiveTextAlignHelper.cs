using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class ResponsiveTextAlignHelper
{
    public static string GetResponsiveTextAlign(BlockGridItem model)
    {
        bool useResponsiveTextAlign = model?.Content.Value<bool>("useResponsiveTextAlign") ?? false;

        if (!useResponsiveTextAlign)
        {
            return string.Empty;
        }

        string GetTextAlignClass(string screenSize, string textAlign)
        {
            return $"text-align-{screenSize}-{textAlign.ToLower()}";
        }

        string GetTextAlignValue(string screenSize, BlockGridItem model)
        {
            var value = model?.Content.Value<string>($"{screenSize}ScreenTextAlign") ?? "";
            return value.Equals("none", StringComparison.OrdinalIgnoreCase) ? "" : value;
        }

        string PropagateTextAlign(string[] screenSizes, BlockGridItem model)
        {
            var textAlignValues = new Dictionary<string, string>();
            string lastValue = "";

            foreach (var screenSize in screenSizes)
            {
                var textAlignValue = GetTextAlignValue(screenSize, model);
                if (!string.IsNullOrEmpty(textAlignValue))
                {
                    lastValue = textAlignValue;
                }
                textAlignValues[screenSize] = lastValue;
            }

            return string.Join(" ", screenSizes.Select(screenSize => GetTextAlignClass(screenSize, textAlignValues[screenSize])));
        }

        var screenSizes = new[] { "mobile", "small", "medium", "large", "xl", "xxl" };

        return PropagateTextAlign(screenSizes, model!);
    }
}
