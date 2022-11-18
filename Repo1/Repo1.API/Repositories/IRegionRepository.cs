using Repo1.API.Models.Domain;

namespace Repo1.API.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();

    }
}
