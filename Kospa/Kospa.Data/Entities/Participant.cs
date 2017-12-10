namespace Kospa.Data
{
    public class Participant : EntityBase
    {
        public Participant(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
