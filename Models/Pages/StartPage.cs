using nackademin24_episerver.Business;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_episerver.Models.Pages
{
    [ContentType(
        GUID = "74551BE0-458F-4E03-B9E7-92556CC22AB6",
        GroupName = Globals.GroupNames.Specialized
    )]
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [CultureSpecific]
        public virtual string Heading { get; set; } = string.Empty;
    }
}