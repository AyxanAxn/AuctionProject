using AuctionProject.Domain.Commons.EntityBases;

namespace AuctionProject.Domain.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
