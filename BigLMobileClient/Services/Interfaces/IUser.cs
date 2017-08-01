using System;
using System.Collections.Generic;
using BigLMobileClient.Dtos;

namespace BigLMobileClient.Services.Interfaces
{
    public interface IUser
    {
        List<string> Users(List<UserDto> users);
        decimal UsersPoints(List<UserDto> users, string username);
    }
}
