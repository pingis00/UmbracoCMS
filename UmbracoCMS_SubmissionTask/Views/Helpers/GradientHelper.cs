using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.PropertyEditors.ValueConverters;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class GradientHelper
{
    public static string GetGradientClasses(BlockGridItem model)
    {
        if (model == null || model.Content == null)
        {
            return string.Empty;
        }

        bool useGradientBackground = model.Content.Value<bool>("useGradientBackground");

        if (!useGradientBackground)
        {
            return string.Empty;
        }

        string GetGradientClass(string screenSize, string color1, string color2, int percentage)
        {
            return $"bg-gradient-{screenSize}-{percentage}-{color1}-{color2}";
        }

        (string color1, string color2, int percentage) GetGradientValues(string screenSize, BlockGridItem model)
        {
            var color1 = model.Content.Value<ColorPickerValueConverter.PickedColor>($"{screenSize}BackgroundColor1")?.Label.ToLower() ?? "default";
            var color2 = model.Content.Value<ColorPickerValueConverter.PickedColor>($"{screenSize}BackgroundColor2")?.Label.ToLower() ?? "default";
            var percentage = model.Content.Value<int?>($"{screenSize}GradientPercentage") ?? 50;

            return (color1, color2, percentage);
        }

        string PropagateGradient(string[] screenSizes, BlockGridItem model)
        {
            var gradientValues = new Dictionary<string, (string color1, string color2, int percentage)>();
            (string color1, string color2, int percentage) lastValues = ("default", "default", 50);

            foreach (var screenSize in screenSizes)
            {
                var gradientValue = GetGradientValues(screenSize, model);
                if (!string.IsNullOrEmpty(gradientValue.color1) && gradientValue.color1 != "none" &&
                    !string.IsNullOrEmpty(gradientValue.color2) && gradientValue.color2 != "none")
                {
                    lastValues = gradientValue;
                }
                gradientValues[screenSize] = lastValues;
            }

            return string.Join(" ", screenSizes.Select(screenSize => GetGradientClass(screenSize, gradientValues[screenSize].color1, gradientValues[screenSize].color2, gradientValues[screenSize].percentage)));
        }

        var screenSizes = new[] { "mobile", "small", "medium", "large", "xl", "xxl" };

        return PropagateGradient(screenSizes, model);
    }
}
