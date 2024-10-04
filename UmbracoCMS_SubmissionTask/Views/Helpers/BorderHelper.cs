using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.PropertyEditors.ValueConverters;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class BorderHelper
{
    public static string GetBorderClass(BlockGridItem model)
    {
        if (model == null || model.Content == null)
        {
            return string.Empty;
        }

        var borderPositions = model?.Content.Value<string[]>("borderPosition") ?? new string[] { "none" };
        var borderThickness = model?.Content.Value<string>("borderThickness") ?? "none";

        var displayBorderMobile = model?.Content.Value<bool>("displayBorderMobile") ?? false;
        var displayBorderSmall = model?.Content.Value<bool>("displayBorderSmall") ?? false;
        var displayBorderMedium = model?.Content.Value<bool>("displayBorderMedium") ?? false;
        var displayBorderLarge = model?.Content.Value<bool>("displayBorderLarge") ?? false;
        var displayBorderXL = model?.Content.Value<bool>("displayBorderXl") ?? false;
        var displayBorderXXL = model?.Content.Value<bool>("displayBorderXxl") ?? false;

        List<string> borderClasses = [];

        foreach (var borderPosition in borderPositions)
        {
            if (borderPosition != "none" && borderThickness != "none")
            {
                borderClasses.Add(displayBorderMobile ? $"border-{borderPosition.ToLower()}-{borderThickness.ToLower()}-mobile" : "");
                borderClasses.Add(displayBorderSmall ? $"border-{borderPosition.ToLower()}-{borderThickness.ToLower()}-small" : "");
                borderClasses.Add(displayBorderMedium ? $"border-{borderPosition.ToLower()}-{borderThickness.ToLower()}-medium" : "");
                borderClasses.Add(displayBorderLarge ? $"border-{borderPosition.ToLower()}-{borderThickness.ToLower()}-large" : "");
                borderClasses.Add(displayBorderXL ? $"border-{borderPosition.ToLower()}-{borderThickness.ToLower()}-xl" : "");
                borderClasses.Add(displayBorderXXL ? $"border-{borderPosition.ToLower()}-{borderThickness.ToLower()}-xxl" : "");
            }
        }

        return string.Join(" ", borderClasses.Where(c => !string.IsNullOrEmpty(c)));

    }

    public static string GetBorderColorClass(BlockGridItem model)
    {
        var borderColor = model?.Content?.Value<ColorPickerValueConverter.PickedColor>("borderColor")?.Label.ToLower() ?? null;

        if (!string.IsNullOrEmpty(borderColor) && borderColor != "default")
        {
            return $"border-color-{borderColor}";
        }

        return string.Empty;

    }

    public static string GetMarginClasses(BlockGridItem model)
    {
        string GetMarginClass(string marginPosition)
        {
            var marginValue = model.Content.Value<string>($"margin{marginPosition}") ?? "none";

            var marginSize = marginValue.Split(' ')[0].ToLower();

            return marginSize switch
            {
                "small" => $"m-{marginPosition.ToLower()}-s",
                "medium" => $"m-{marginPosition.ToLower()}-m",
                "large" => $"m-{marginPosition.ToLower()}-l",
                "xl" => $"m-{marginPosition.ToLower()}-xl",
                "xxl" => $"m-{marginPosition.ToLower()}-xxl",
                _ => string.Empty
            };
        }

        var marginTop = GetMarginClass("Top");
        var marginBottom = GetMarginClass("Bottom");
        var marginLeft = GetMarginClass("Left");
        var marginRight = GetMarginClass("Right");

        return $"{marginTop} {marginBottom} {marginLeft} {marginRight}".Trim();
    }
}
