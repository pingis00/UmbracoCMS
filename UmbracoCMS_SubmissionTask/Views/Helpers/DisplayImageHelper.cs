using Umbraco.Cms.Core.Models.Blocks;

namespace UmbracoCMS_SubmissionTask.Views.Helpers
{
    public static class DisplayImageHelper
    {
        public static string GetDisplayClasses(BlockGridItem model)
        {
            var displayBackgroundImageMobile = model?.Content.Value<bool>("displayBackgroundImageMobile") ?? false;
            var displayBackgroundImageSmall = model?.Content.Value<bool>("displayBackgroundImageSmall") ?? false;
            var displayBackgroundImageMedium = model?.Content.Value<bool>("displayBackgroundImageMedium") ?? false;
            var displayBackgroundImageLarge = model?.Content.Value<bool>("displayBackgroundImageLarge") ?? false;
            var displayBackgroundImageXL = model?.Content.Value<bool>("displayBackgroundImageXL") ?? false;
            var displayBackgroundImageXXL = model?.Content.Value<bool>("displayBackgroundImageXXL") ?? false;

            return $@"
                {(displayBackgroundImageMobile ? "d-block" : "d-none")}
                {(displayBackgroundImageSmall ? "d-small-block" : "d-small-none")}
                {(displayBackgroundImageMedium ? "d-medium-block" : "d-medium-none")}
                {(displayBackgroundImageLarge ? "d-large-block" : "d-large-none")}
                {(displayBackgroundImageXL ? "d-xl-block" : "d-xl-none")}
                {(displayBackgroundImageXXL ? "d-xxl-block" : "d-xxl-none")}
            ";
        }
    }
}
