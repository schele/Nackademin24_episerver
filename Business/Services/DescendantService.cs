using nackademin24_episerver.Business.Services.Interfaces;

namespace nackademin24_episerver.Business.Services
{
    public class DescendantService : IDescendantService
    {
        private readonly IContentRepository _contentRepository;

        public DescendantService(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public IEnumerable<T> GetDescendantsOfType<T>(PageData pageData) where T : class
        {
            var results = new List<T>();
            Traverse(pageData, results);
            return results;

            void Traverse(PageData node, ICollection<T> list)
            {
                var children = _contentRepository.GetChildren<PageData>(node.ContentLink);

                foreach (var child in children)
                {
                    if (child is T match)
                    {
                        list.Add(match);
                    }

                    Traverse(child, list);
                }
            }
        }
    }
}