using AuctionProject.Domain.Commons.EntityBases;
using System;

namespace AuctionProject.Domain.Entities
{
    public class Auction:IEntity, IAuditableEntity
    {
        public int Id { get; set; }
        public decimal StartBid { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int UserLimit { get; set; }
        public decimal MinimumOffer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public int CreatorId { get; set; }
        public int? ModifierId { get; set; }
    }
}