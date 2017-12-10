using Kospa.Data.Helpers;
using System;
using System.Collections.Generic;

namespace Kospa.Data.Context
{
    public class MeetingContext
    {
        static MeetingContext()
        {
            Users = new HashSet<Participant>(new ParticipantComparer());
            var user1 = new Participant(1, "Can", "PERK");
            var user2 = new Participant(2, "Cem", "SÖNMEZ");
            var user3 = new Participant(3, "Serkan", "KAYA");
            var user4 = new Participant(4, "Taha", "İPEK");
            var user5 = new Participant(5, "Berk", "ARSLAN");
            var user6 = new Participant(6, "Alp", "ÇOKER");
            var user7 = new Participant(7, "Seçkin", "BEDÜK");
            var user8 = new Participant(8, "Gencebay", "DEMİR");
            var user9 = new Participant(9, "Mustafa", "KÖLELİ");
            var user10 = new Participant(10, "Olcay", "ÜNVER");
            var user11 = new Participant(11, "Gökhan", "İPEK");
            Users.Add(user1);
            Users.Add(user2);
            Users.Add(user3);
            Users.Add(user4);
            Users.Add(user5);
            Users.Add(user6);
            Users.Add(user7);
            Users.Add(user8);
            Users.Add(user9);
            Users.Add(user10);
            Users.Add(user11);

            Meetings = new HashSet<Meeting>();
            var meeting1 = new Meeting() { Id = 1, Title = "Scrum", Date = DateTime.Now.AddHours(-2).AddMinutes(39) };
            meeting1.AddUsers(user1, user4, user6);
            var meeting2 = new Meeting() { Id = 2, Title = "Finance", Date = DateTime.Now.AddHours(5).AddMinutes(45) };
            meeting2.AddUsers(user6, user11, user8);
            var meeting3 = new Meeting() { Id = 3, Title = "CRM", Date = DateTime.Now.AddHours(-12).AddMinutes(25) };
            meeting3.AddUsers(user10, user1, user5, user8);
            var meeting4 = new Meeting() { Id = 4, Title = "Scrum", Date = DateTime.Now.AddHours(1).AddMinutes(7) };
            meeting4.AddUsers(user2, user3, user10, user9, user7);
            var meeting5 = new Meeting() { Id = 5, Title = "Project Startup", Date = DateTime.Now.AddHours(-7).AddMinutes(-5) };
            meeting5.AddUsers(user6, user8, user3, user11, user7);
            var meeting6 = new Meeting() { Id= 6, Title = "New Employment", Date = DateTime.Now.AddHours(7).AddMinutes(23) };
            meeting6.AddUsers(user6, user5, user2, user8);
            var meeting7 = new Meeting() { Id = 7, Title = "Finance", Date = DateTime.Now.AddHours(26).AddMinutes(16) };
            meeting7.AddUsers(user1, user2, user3, user9, user10, user4);
            var meeting8 = new Meeting() { Id = 8, Title = "Scrum", Date = DateTime.Now.AddHours(36).AddMinutes(1) };
            meeting8.AddUsers(user11, user5, user6, user10);
            Meetings.Add(meeting1);
            Meetings.Add(meeting2);
            Meetings.Add(meeting3);
            Meetings.Add(meeting4);
            Meetings.Add(meeting5);
            Meetings.Add(meeting6);
            Meetings.Add(meeting7);
            Meetings.Add(meeting8);
        }
        public static HashSet<Participant> Users { get; set; }
        public static HashSet<Meeting> Meetings { get; set; }
    }
}
