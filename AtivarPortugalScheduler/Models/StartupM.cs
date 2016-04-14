using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtivarPortugalScheduler.Models
{
    public class StartupM
    {
        [Key]
        public string StartupName { get; set; }
        public string PDFUrl { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}