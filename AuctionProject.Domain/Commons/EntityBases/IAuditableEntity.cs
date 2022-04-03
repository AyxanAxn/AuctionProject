using System;

namespace AuctionProject.Domain.Commons.EntityBases
{
    public interface IAuditableEntity
    {
        public DateTimeOffset CreationDate { get; set; }
        public int CreatorId { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public int? ModifierId{ get; set; }

    }
}
