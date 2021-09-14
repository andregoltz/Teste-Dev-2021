using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Teste.Domain.Models;

namespace Teste.Application.ViewModels
{
    public class UserViewModel: Person
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
