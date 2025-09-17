using Microsoft.AspNetCore.Mvc;
using nackademin24_episerver.Models.Pages;
using nackademin24_episerver.Models.ViewModels;

namespace nackademin24_episerver.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);

            return View(model);
        }
    }
}