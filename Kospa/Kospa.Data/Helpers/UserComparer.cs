using System.Collections.Generic;

namespace Kospa.Data.Helpers
{
    public class ParticipantComparer : IEqualityComparer<Participant>
    {
        public bool Equals(Participant x, Participant y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(Participant obj)
        {
            return obj.Id;
        }
    }
}
