﻿using System;
using Teste.Domain.Models;

namespace Teste.Domain
{
    public class User : Person
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
