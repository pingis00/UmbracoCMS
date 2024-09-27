using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers;

public class WidthHelper
{
    public static string GetWidthClasses(BlockGridItem model)
    {
        var classes = new List<string>();

        var screenSizes = new[] { "mobileScreen", "smallScreen", "mediumScreen", "largeScreen", "xlScreen", "xxlScreen" };
        foreach (var size in screenSizes)
        {
            var width = model?.Content.Value<string>(size) ?? "";
            if (!string.IsNullOrEmpty(width) && width.ToLower() != "default")
            {
                var widthValue = width.Replace("%", "");
                var className = $"width-{size.Replace("Screen", "").ToLower()}-{widthValue}";
                classes.Add(className);
            }
        }

        return string.Join(" ", classes);
    }
}
