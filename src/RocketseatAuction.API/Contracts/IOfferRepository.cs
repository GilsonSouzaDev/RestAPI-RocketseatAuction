using RocketseatAuction.API.Communication.Requests;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
