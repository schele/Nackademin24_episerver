using nackademin24_episerver.Models.Pages;

namespace nackademin24_episerver.Business.Services.Interfaces
{
    public interface IXmlSitemapService
    {
        IEnumerable<SitePageData> GetPages(XmlSitemap currentPage);
    }
}