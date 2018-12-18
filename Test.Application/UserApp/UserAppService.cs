using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Application.UserApp.Dto;
using Test.Core.User;
using Test.Domain;

namespace Test.Application.UserApp
{
    public class UserAppService
    {
        private readonly IRepository<User> _repository;

        public UserAppService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public void InsertUser(UserDto input)
        {
            var user = Mapper.Map<User>(input);
            _repository.Insert(user);
        }
    }
}
