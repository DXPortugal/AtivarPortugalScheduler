using AtivarPortugalScheduler.Models;
using System;
using System.Collections.Generic;

namespace AtivarPortugalScheduler.DAL
{
    public class SpeedDatingInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SpeedDatingContext>
    {
        protected override void Seed(SpeedDatingContext context)
        {
            var startups = new List<StartupM>
            {
                new StartupM {StartupName="TOPDOX", PDFUrl = "none", Code="28172649" },
                new StartupM {StartupName="Healthy Road", PDFUrl = "Content/PDFs/1231412.pdf", Code="83917492"  },
                new StartupM {StartupName="knok", PDFUrl = "Content/PDFs/1231412.pdf", Code="77273917"  },
                new StartupM {StartupName="loqr", PDFUrl = "Content/PDFs/1231412.pdf", Code="11847231"  },
                new StartupM {StartupName="Sword Health", PDFUrl = "Content/PDFs/1231412.pdf", Code="07957281"  },
                new StartupM {StartupName="isGreen", PDFUrl = "Content/PDFs/1231412.pdf", Code="06891232"  }
            };
            startups.ForEach(s => context.StartupMs.Add(s));
            context.SaveChanges();

            var companies = new List<Company>
            {
                new Company {Code="89345223", CompanyName="Caixa Capital" },
                new Company {Code="15135195", CompanyName="Espirito Santo Ventures" },
                new Company {Code="24127634", CompanyName="Startup Braga" },
                new Company {Code="89346152", CompanyName="Novabase" },
                new Company {Code="08460123", CompanyName="Portugal Ventures" },
                new Company {Code="91348670", CompanyName="AICEP" }
            };

            companies.ForEach(c => context.Companies.Add(c));
            context.SaveChanges();

            var rooms = new List<Room>
            {
                new Room {RoomName="WebMatrix", Floor="2N" },
                new Room {RoomName="Skype", Floor="0N" },
                new Room {RoomName="Kinect", Floor="0N" },
                new Room {RoomName="OneNote", Floor="1S" },
                new Room {RoomName="MediaRoom", Floor="1N" },
                new Room {RoomName="Bing", Floor="3N" }
            };
            rooms.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();

            var meetings = new List<Meeting>
            {
                new Meeting {StartupName = @"loqr", CompanyName = @"Caixa Capital", RoomName = @"WebMatrix", MeetingTime = @DateTime.Parse("2016-04-06 15:00") },
                new Meeting {StartupName = @"TOPDOX", CompanyName = @"Espirito Santo Ventures", RoomName = @"Skype", MeetingTime = @DateTime.Parse("2016-04-06 15:00") },
                new Meeting {StartupName = @"knok", CompanyName = @"Startup Braga", RoomName = @"Kinect", MeetingTime = @DateTime.Parse("2016-04-06 15:00") },
                new Meeting {StartupName = @"Sword Health", CompanyName = @"Novabase", RoomName = @"OneNote", MeetingTime = @DateTime.Parse("2016-04-06 15:00") },
                new Meeting {StartupName = @"isGreen", CompanyName = @"Portugal Ventures", RoomName = @"MediaRoom", MeetingTime = @DateTime.Parse("2016-04-06 15:00") },
                new Meeting {StartupName = @"Healthy Road", CompanyName = @"AICEP", RoomName = @"Bing", MeetingTime = @DateTime.Parse("2016-04-06 15:00") },
                new Meeting {StartupName = @"TOPDOX", CompanyName = @"Caixa Capital", RoomName = @"WebMatrix", MeetingTime = @DateTime.Parse("2016-04-06 16:00") },
                new Meeting {StartupName = @"loqr", CompanyName = @"Espirito Santo Ventures", RoomName = @"Skype", MeetingTime = @DateTime.Parse("2016-04-06 16:00") },
                new Meeting {StartupName = @"Sword Health", CompanyName = @"Startup Braga", RoomName = @"Kinect", MeetingTime = @DateTime.Parse("2016-04-06 16:00") },
                new Meeting {StartupName = @"knok", CompanyName = @"Novabase", RoomName = @"OneNote", MeetingTime = @DateTime.Parse("2016-04-06 16:00") },
                new Meeting {StartupName = @"Healthy Road", CompanyName = @"Portugal Ventures", RoomName = @"MediaRoom", MeetingTime = @DateTime.Parse("2016-04-06 16:00") },
                new Meeting {StartupName = @"isGreen", CompanyName = @"AICEP", RoomName = @"Bing", MeetingTime = @DateTime.Parse("2016-04-06 16:00") },
                new Meeting {StartupName = @"Healthy Road", CompanyName = @"Caixa Capital", RoomName = @"WebMatrix", MeetingTime = @DateTime.Parse("2016-04-06 17:00") },
                new Meeting {StartupName = @"isGreen", CompanyName = @"Espirito Santo Ventures", RoomName = @"Skype", MeetingTime = @DateTime.Parse("2016-04-06 17:00") }
            };
            meetings.ForEach(m => context.Meetings.Add(m));
            context.SaveChanges();
        }
    }
}