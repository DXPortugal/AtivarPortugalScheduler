using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AtivarPortugalScheduler.Models
{
    public class Company
    {
        [Key, DisplayName("Nome da Empresa")]
        public string CompanyName { get; set; }

        public string Code { get; set; }

        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}