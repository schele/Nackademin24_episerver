using Microsoft.AspNetCore.Mvc;
using nackademin24_episerver.Models.Pages;
using nackademin24_episerver.Models.ViewModels;

namespace nackademin24_episerver.Controllers
{
    public class ErrorPageController : PageControllerBase<ErrorPage>
    {
        public IActionResult Index(ErrorPage currentPage)
        {
            var model = new ErrorPageViewModel(currentPage);

            return View(model);
        }
    }
}