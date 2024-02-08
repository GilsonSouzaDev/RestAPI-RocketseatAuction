using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using System.Data.Common;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionContext : DbContext
{

    public RocketseatAuctionContext(DbContextOptions options) : base(options){ }

    public DbSet<Auction> Auctions { get; set; } 
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
    
}
