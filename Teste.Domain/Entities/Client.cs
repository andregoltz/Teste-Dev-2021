using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Models;

namespace Teste.Domain.Entities
{
    public class Client : Person
    {
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
