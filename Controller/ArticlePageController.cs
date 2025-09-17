using Microsoft.AspNetCore.Mvc;
using nackademin24_episerver.Models.Pages;
using nackademin24_episerver.Models.ViewModels;

namespace nackademin24_episerver.Controller
{
    public class ArticlePageController : PageControllerBase<ArticlePage>
    {
        public IActionResult Index(ArticlePage currentPage)
        {
            var model = new ArticlePageViewModel(currentPage);

            return View(model);
        }
    }
}