namespace nackademin24_episerver.Business.Services.Interfaces
{
    public interface IDescendantService
    {
        IEnumerable<T> GetDescendantsOfType<T>(PageData pageData) where T : class;
    }
}