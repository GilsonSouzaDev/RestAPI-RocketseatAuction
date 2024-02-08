using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using System.Reflection.Metadata;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class UserRepository: IUserRepository
{
    private readonly RocketseatAuctionContext _dbContext;

    public UserRepository(RocketseatAuctionContext dbContext) => _dbContext = dbContext;


    public bool ExisteUserWithEmail(string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(String email) => _dbContext.Users.First(user => user.Email.Equals(email));
}
