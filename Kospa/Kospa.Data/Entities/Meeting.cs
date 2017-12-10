using Kospa.Data.Helpers;
using System;
using System.Collections.Generic;

namespace Kospa.Data
{
    public class Meeting : EntityBase
    {
        public Meeting()
        {
            Users = new HashSet<Participant>(new ParticipantComparer());
        }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Participant> Users { get; protected set; }

        public void AddUser(Participant user)
        {
            Users.Add(user);
        }

        public void AddUsers(params Participant[] users)
        {
            foreach (var user in users)
            {
                Users.Add(user);
            }
        }
    }
}
