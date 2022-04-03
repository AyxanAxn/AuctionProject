namespace AuctionProject.Domain.Entities
{
    public class AuctionSubcribers
    {
        public int AuctionId { get; set; }
        public Auction Auction { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
