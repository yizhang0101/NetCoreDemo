﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Core.User
{
    public class User: EntityBase
    {
        //public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
    }
}
