using Repo1.API.Data;
using Repo1.API.Models.Domain;

namespace Repo1.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly Repo1DBContext repo1DBContext;

        public RegionRepository(Repo1DBContext repo1DBContext)
        {
            this.repo1DBContext = repo1DBContext;
        }
        public IEnumerable<Region> GetAll()
        {
            return repo1DBContext.Regions.ToList();
        }
    }
}
