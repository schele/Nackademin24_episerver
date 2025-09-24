using Microsoft.AspNetCore.Mvc;
using nackademin24_episerver.Business.Services.Interfaces;
using nackademin24_episerver.Models.Pages;
using nackademin24_episerver.Models.ViewModels;

namespace nackademin24_episerver.Controllers
{
    public class XmlSitemapController(IXmlSitemapService sitemapService) : PageControllerBase<XmlSitemap>
    {
        private readonly IXmlSitemapService _sitemapService = sitemapService;

        public IActionResult Index(XmlSitemap currentPage)
        {
            var model = new XmlSitemapViewModel(currentPage)
            {
                Pages = _sitemapService.GetPages(currentPage)
            };

            return View(model);
        }
    }
}