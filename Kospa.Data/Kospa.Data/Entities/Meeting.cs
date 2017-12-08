using Kospa.Data.Helpers;
using System.Collections.Generic;

namespace Kospa.Data
{
    public class Meeting : EntityBase
    {
        public Meeting()
        {
            Users = new HashSet<User>(new UserComparer());
        }
        public string Title { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
