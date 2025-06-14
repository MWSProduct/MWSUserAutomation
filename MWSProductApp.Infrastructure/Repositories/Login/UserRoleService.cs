using System;
using System.Threading.Tasks;
using MWSProductApp.Contract.Data.Login;
namespace MWSProductApp.Infrastructure.Repositories.Login;


public class UserRoleService : IUserRoleRepository
{
    public Task<object> GetUserRoleById(string userId)
    {
        if (string.IsNullOrEmpty(userId))
        {
            throw new ArgumentException("User ID cannot be null or empty", nameof(userId));
        }
        return Task.FromResult<object>("Admin");
    }

    public Task<object> GetAllUserRoles()
    {
        return Task.FromResult<object>(new[] { "Admin", "User", "Guest" });
    }
}