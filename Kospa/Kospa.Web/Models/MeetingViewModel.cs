using System;

namespace Kospa.Web.Models
{
    public class MeetingViewModel
    {
        public string Title { get; set; }
        public DateTime MeetingDate { get; set; }
        public int ParticipantCount { get; set; }
    }
}
