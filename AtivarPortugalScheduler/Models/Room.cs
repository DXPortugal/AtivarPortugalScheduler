using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AtivarPortugalScheduler.Models
{
    public class Room
    {
        [Key, DisplayName("Nome da Sala")]
        public string RoomName { get; set; }

        [DisplayName("Piso")]
        public string Floor { get; set; }

        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}