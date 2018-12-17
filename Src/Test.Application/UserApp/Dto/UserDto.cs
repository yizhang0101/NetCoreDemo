using System;
using System.Collections.Generic;
using System.Text;
using Test.Core;

namespace Test.Application.UserApp.Dto
{
    public class UserDto : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
    }
}
