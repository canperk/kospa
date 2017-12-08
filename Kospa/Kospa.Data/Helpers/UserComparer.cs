using System.Collections.Generic;

namespace Kospa.Data.Helpers
{
    public class UserComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(User obj)
        {
            return obj.Id;
        }
    }
}
