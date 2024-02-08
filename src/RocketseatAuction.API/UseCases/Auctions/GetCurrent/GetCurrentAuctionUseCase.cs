using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _auctionRepository;

    public GetCurrentAuctionUseCase(IAuctionRepository auctionRepository) => _auctionRepository = auctionRepository;
   
    public Auction? Execute()
    {
        return _auctionRepository.GetCurrent();   
    }

}

