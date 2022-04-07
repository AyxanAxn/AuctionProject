using System;
using AuctionProject.Domain.Commons.EntityBases;
using AuctionProject.Infrastructure.EF.Databases;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

[assembly: HostingStartup(typeof(AuctionProject.Areas.Identity.IdentityHostingStartup))]
namespace AuctionProject.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}