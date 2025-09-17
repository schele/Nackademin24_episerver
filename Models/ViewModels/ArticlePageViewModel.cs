using nackademin24_episerver.Models.Pages;

namespace nackademin24_episerver.Models.ViewModels
{
    public class ArticlePageViewModel : PageViewModel<ArticlePage>
    {
        public ArticlePageViewModel(ArticlePage currentPage) : base(currentPage)
        {
        }
    }
}