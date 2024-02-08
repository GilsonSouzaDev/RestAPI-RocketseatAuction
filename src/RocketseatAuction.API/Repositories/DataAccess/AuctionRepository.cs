using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class AuctionRepository: IAuctionRepository
{
    private readonly RocketseatAuctionContext _dbContext;

    public AuctionRepository(RocketseatAuctionContext dbContext) => _dbContext = dbContext;


    public Auction? GetCurrent()
    {
        var today = DateTime.Now;

        return _dbContext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault();
    }
  
}
