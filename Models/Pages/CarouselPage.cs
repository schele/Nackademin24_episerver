using nackademin24_episerver.Business;
using nackademin24_episerver.Business.Attributes;
using nackademin24_episerver.Business.Enums;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_episerver.Models.Pages
{
    [ContentType(
        GUID = "E1534F12-61D6-494C-B3DE-F2D01A26D03E",
        GroupName = Globals.GroupNames.Specialized,
        DisplayName = "Carousel",
        Description = ""
    )]
    [ContentIcon(ContentIcon.ObjectImage)]
    public class CarouselPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        public virtual ContentReference Image { get; set; }
    }
}