using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Application.ViewModels
{
    public class ClientViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string BirthDate { get; set; }
    }
}
