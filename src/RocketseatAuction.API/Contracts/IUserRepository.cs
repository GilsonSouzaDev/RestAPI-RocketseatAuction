using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public interface IUserRepository
{
    bool ExisteUserWithEmail(string email);
    User GetUserByEmail(String email);
}
