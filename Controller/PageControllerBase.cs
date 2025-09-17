using EPiServer.Web.Mvc;
using nackademin24_episerver.Models.Pages;

namespace nackademin24_episerver.Controller
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
    }
}
