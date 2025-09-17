using nackademin24_episerver.Models.Pages;

namespace nackademin24_episerver.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }

        LayoutModel Layout { get; set; }
    }
}