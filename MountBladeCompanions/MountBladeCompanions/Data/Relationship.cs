using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountBladeCompanions.Data
{
    class Relationship
    {
        public Companion From { get; set; }

        public Companion To { get; set; }

        public Relation Relation { get; set; }
        
        public Relationship(Companion from, Companion to, Relation relation)
        {
            From = from;
            To = to;
            Relation = relation;
        }

        public bool IsInDislikeRelation(Companion companion)
        {
            if (Relation == Relation.Dislikes && (companion.Equals(From) || companion.Equals(To)))
                return true;
            return false;
        }
    }
}
