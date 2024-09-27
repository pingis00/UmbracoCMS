using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class FontWeightHelper
{
    public static string GetFontWeightClasses(BlockGridItem model)
    {
        var fontWeight = model?.Content.Value<string[]>("fontWeight")?.FirstOrDefault()
                            ?? model?.Content.Value<string>("fontWeight")
                            ?? "";

        if (string.IsNullOrEmpty(fontWeight) || fontWeight.Equals("default", StringComparison.OrdinalIgnoreCase))
        {
            return "";
        }

        return fontWeight.Split(' ')[0] switch
        {
            "300" => "font-weight-300",
            "400" => "font-weight-400",
            "500" => "font-weight-500",
            "600" => "font-weight-600",
            "700" => "font-weight-700",
            "800" => "font-weight-800",
            _ => ""
        };
    }
}
