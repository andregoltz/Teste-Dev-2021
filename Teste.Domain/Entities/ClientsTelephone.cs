using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Teste.Domain.Entities
{
    public class ClientsTelephone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Guid IdClient { get; set; }
        public string DDD { get; set; }
        public string TelephoneNumber { get; set; }
        public bool IsDeleted { get; set; }
    }
}
