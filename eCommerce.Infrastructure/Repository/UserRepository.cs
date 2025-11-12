using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;

namespace eCommerce.Infrastructure.Repository
{
    internal class UserRepository : IUserRepository
    {
        public async Task<ApplicationUser?> AddUser(ApplicationUser user)
        {

            user.UserID = Guid.NewGuid();
            return user;
        }

        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string password)
        {
            return new ApplicationUser()
            {
                UserID = Guid.NewGuid(),
                Email = email,
                Password = password
            };
        }
    }
}
