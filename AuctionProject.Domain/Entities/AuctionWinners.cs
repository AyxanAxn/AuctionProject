using AuctionProject.Domain.Commons.EntityBases;
using System;

namespace AuctionProject.Domain.Entities
{
    public class AuctionWinners
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int AuctionId { get; set; }
        public Auction Auction { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
    }
}
