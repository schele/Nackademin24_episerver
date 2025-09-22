using EPiServer.Web;
using nackademin24_episerver.Business;
using nackademin24_episerver.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_episerver.Models.Pages
{
    [ContentType(
        GUID = "74551BE0-458F-4E03-B9E7-92556CC22AB6",
        GroupName = Globals.GroupNames.Specialized
    )]

    [ImageUrl("/pages/CMS-icon-page-02.png")]
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [CultureSpecific]
        public virtual string Heading { get; set; } = string.Empty;

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string Preamble { get; set; } = string.Empty;

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        [CultureSpecific]
        [ScaffoldColumn(false)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 40
        )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 50
        )]
        [CultureSpecific]
        [AllowedTypes(typeof(CarouselPage), typeof(CarouselBlock))]
        public virtual ContentArea Carousel { get; set; }
    }
}