using System;
using System.Collections.Generic;
using BigLMobileClient.Dtos;
using BigLMobileClient.Services.Interfaces;
using System.Linq;

namespace BigLMobileClient.Services
{
    public class UserActions : IUser
    {
        public UserActions()
        {
        }

        public List<string> Users(List<UserDto> users)
        {
            return users.Select(name=>name.Username).ToList();
        }

        public decimal UsersPoints(List<UserDto> users, string username)
        {
            return users.FirstOrDefault(name=>name.Username == username).PointsAmount;
        }
    }
}
