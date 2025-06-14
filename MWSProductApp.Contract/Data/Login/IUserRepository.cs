using System;
using MWSProductApp.Model;
namespace MWSProductApp.Contract.Data.Login;

public interface IUserRepository
{
    Task<MWSUserRegister> GetEmailId(string emailId);
    Task<MWSUserRegister> GetPhoneNumber(string PhoneNumber);
    Task<object> GetAll();

}
