using System;
using MWSProductApp.Contract.Data.Login;
using MWSProductApp.Model;
namespace MWSProductApp.Infrastructure.Repositories.Login;

public class UserRegisterRepo : IUserRepository
{
    public Task<MWSUserRegister> GetEmailId(string emailId)
    {
        throw new NotImplementedException();
    }

    public Task<MWSUserRegister> GetPhoneNumber(string PhoneNumber)
    {
        throw new NotImplementedException();
    }

    public Task<object> GetAll()
    {
        throw new NotImplementedException();
    }

}
