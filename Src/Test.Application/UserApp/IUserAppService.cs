using System;
using System.Collections.Generic;
using System.Text;
using Test.Application.UserApp.Dto;

namespace Test.Application.UserApp
{
    public interface IUserAppService
    {
        void InsertUser(UserDto input);
    }
}
