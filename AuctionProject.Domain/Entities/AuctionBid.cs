using AuctionProject.Domain.Commons.EntityBases;
using System;

namespace AuctionProject.Domain.Entities
{
    public class AuctionBid:IEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int AuctionId { get; set; }
        public Auction Auction { get; set; }
        public DateTimeOffset CreationDate { get; set; }
    }
}