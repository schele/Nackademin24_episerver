using nackademin24_episerver.Business;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_episerver.Models.Pages
{
    public class SitePageData : PageData
    {
        [Display(
            GroupName = Globals.GroupNames.MetaData,
            Order = 120
        )]
        [CultureSpecific]
        public virtual string MetaDescription
        {
            get
            {
                var metaDescription = this.GetPropertyValue(p => p.MetaDescription);

                return !string.IsNullOrWhiteSpace(metaDescription) ? metaDescription : Name;
            }
            set => this.SetPropertyValue(p => p.MetaDescription, value);
        }

        [Display(
            GroupName = SystemTabNames.Settings,
            Order = 10
        )]
        [Editable(false)]
        [CultureSpecific]
        public virtual DateTime? XmlSitemapDate { get; set; }
    }
}