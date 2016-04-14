using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtivarPortugalScheduler.Models
{
    public class Meeting
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("StartupM")]
        public string StartupName { get; set; }

        [ForeignKey("Company")]
        public string CompanyName { get; set; }

        [ForeignKey("Room")]
        public string RoomName { get; set; }

        [DisplayName("Hora")]
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime MeetingTime { get; set; }

        public virtual StartupM StartupM { get; set; }
        public virtual Company Company { get; set; }
        public virtual Room Room { get; set; }
    }
}