using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionProject.Domain.Commons.EntityBases
{
    public class UserBase: IdentityUser<int>, IEntity   
    {        
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }        
    }
}
