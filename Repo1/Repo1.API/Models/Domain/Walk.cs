namespace Repo1.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid WalkDifficultyId { get; set; }
        public Guid RegionId { get; set; }
        //navigation
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }




    }
}
