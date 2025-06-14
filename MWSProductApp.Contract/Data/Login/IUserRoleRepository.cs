using System;
using System.Threading.Tasks;

namespace MWSProductApp.Contract.Data.Login
{
    public interface IUserRoleRepository
    {
        Task<object> GetAllUserRoles();
        Task<object> GetUserRoleById(string userId);
    }
}