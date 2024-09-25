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
                {(displayBackgroundImageMobile ? "" : "d-none d-sm-block")}
                {(displayBackgroundImageSmall ? "" : "d-sm-none d-md-block")}
                {(displayBackgroundImageMedium ? "" : "d-md-none d-lg-block")}
                {(displayBackgroundImageLarge ? "" : "d-lg-none d-xl-block")}
                {(displayBackgroundImageXL ? "" : "d-xl-none d-xxl-block")}
                {(displayBackgroundImageXXL ? "" : "d-xxl-none")}
            ";
        }
    }
}
