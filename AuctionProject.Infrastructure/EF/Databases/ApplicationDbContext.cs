using AuctionProject.Domain.Commons.EntityBases;
using AuctionProject.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionProject.Infrastructure.EF.Databases
{
    public class ApplicationDbContext : IdentityDbContext<UserBase, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> RegularUsers { get; set; }
        public DbSet<Admin> Admins { get; set; }        
        public DbSet<AuctionBid> AuctionBids { get; set; }
        public DbSet<AuctionSubcribers> AuctionSubcribers { get; set; }
        public DbSet<AuctionWinners> AuctionWinners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AuctionSubcribers>().HasKey(i => new { i.AuctionId, i.UserId});
            builder.Entity<AuctionWinners>().HasKey(i => new { i.AuctionId, i.UserId});

            base.OnModelCreating(builder);
        }
    }
}