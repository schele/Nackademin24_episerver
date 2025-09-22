using EPiServer.PlugIn;
using EPiServer.Scheduler;
using EPiServer.Web;
using nackademin24_episerver.Business.Services.Interfaces;
using nackademin24_episerver.Models.Pages;

namespace nackademin24_episerver.Business.ScheduledJobs
{
    [ScheduledPlugIn(
        GUID = "1B5DCBD3-A6D1-4B9F-803B-7FAE1D956014",
        DisplayName = "Delete unpublished carousel pages"
    )]
    public class DeleteUnpublishedCarouselPages : ScheduledJobBase
    {
        private readonly IContentLoader _contentLoader;
        private readonly ISiteDefinitionRepository _siteDefinitionRepository;
        private readonly IContentRepository _contentRepository;
        private readonly IDescendantService _descendantService;
        private bool _stopSignaled;

        public DeleteUnpublishedCarouselPages(IContentLoader contentLoader, ISiteDefinitionRepository siteDefinitionRepository, IContentRepository contentRepository, IDescendantService descendantService)
        {
            _contentLoader = contentLoader;
            _siteDefinitionRepository = siteDefinitionRepository;
            _contentRepository = contentRepository;
            _descendantService = descendantService;
            IsStoppable = true;
        }

        public override void Stop()
        {
            _stopSignaled = true;
        }


        public override string Execute()
        {
            var carouselPages = GetCarouselPages();
            var status = 0;

            foreach (var item in carouselPages)
            {
                if (item.StopPublish != null)
                {
                    _contentRepository.Delete(item.ContentLink, true, EPiServer.Security.AccessLevel.NoAccess);

                    status++;
                }
            }

            if (_stopSignaled)
            {
                return $"The joba has been cancelled";
            }

            return $"Unpublished carousel pages deleted: {status}";
        }

        private IEnumerable<CarouselPage> GetCarouselPages()
        {
            var contentReference = _siteDefinitionRepository.List().FirstOrDefault().StartPage;
            var startPage = _contentLoader.Get<StartPage>(contentReference);
            var carouselPages = _descendantService.GetDescendantsOfType<CarouselPage>(startPage).ToList();

            return carouselPages;
        }
    }
}
