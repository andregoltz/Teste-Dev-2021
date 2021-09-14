using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Application.ViewModels
{
    public class TelephonesViewModel
    {
        public int Id { get; set; }
        public Guid IdClient { get; set; }
        public string DDD { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
