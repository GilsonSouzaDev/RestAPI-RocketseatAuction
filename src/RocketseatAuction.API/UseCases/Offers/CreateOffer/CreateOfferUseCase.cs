using RocketseatAuction.API.Communication.Requests;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;
using RocketseatAuction.API.Services;

namespace RocketseatAuction.API.UseCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly ILoggedUser _loggeduser;
    private readonly IOfferRepository _repository;
    
    

    public CreateOfferUseCase(ILoggedUser loggeduser, IOfferRepository repository)
    {

        _loggeduser = loggeduser;
        _repository = repository;

    }

    public int Execute(int itemId, RequestCreateOfferJson request)
    {
        
        var user = _loggeduser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id
        };


        _repository.Add(offer);
        
        return offer.Id;
    }
}
