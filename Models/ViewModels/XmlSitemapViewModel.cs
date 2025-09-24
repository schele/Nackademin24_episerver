using nackademin24_episerver.Models.Pages;

namespace nackademin24_episerver.Models.ViewModels
{
    public class XmlSitemapViewModel : PageViewModel<XmlSitemap>
    {
        public XmlSitemapViewModel(XmlSitemap currentPage) : base(currentPage)
        {
        }

        public IEnumerable<SitePageData> Pages { get; set; }
    }
}