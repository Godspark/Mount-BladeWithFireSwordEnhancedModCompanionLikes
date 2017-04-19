using MountBladeCompanions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountBladeCompanions.Operators
{
    class Analyzer
    {
        private readonly List<Relationship> _relationships;

        public Analyzer(IEnumerable<Relationship> relationships)
        {
            _relationships = new List<Relationship>(relationships);
        }

        public void Analyze()
        {

        }
            

        private IEnumerable<Companion> WhoAreFine(List<Companion> companionsLeft, Companion companionToEvaluate)
        {
            foreach (var relationship in _relationships.Where(p => p.IsInDislikeRelation(companionToEvaluate)))
            {
                companionsLeft.Remove(relationship.From);
                companionsLeft.Remove(relationship.To);
            }
            return companionsLeft;
        }
    }
}
