﻿using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using System;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class OfferRepository: IOfferRepository
{
    private readonly RocketseatAuctionContext _dbContext;

    public OfferRepository(RocketseatAuctionContext dbContext) => _dbContext = dbContext;
    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}
