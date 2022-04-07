using AuctionProject.Domain.Commons.EntityBases;
using System;

namespace AuctionProject.Domain.Entities
{
    public class Product : IEntity, IAuditableEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Vendor { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatorId { get; set; }
        public int? ModifierId { get; set; }
    }
}
