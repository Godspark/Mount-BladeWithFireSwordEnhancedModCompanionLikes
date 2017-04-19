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
        private readonly List<Companion> _allCompanions;

        public Analyzer(IEnumerable<Relationship> relationships, IEnumerable<Companion> allCompanions)
        {
            _relationships = new List<Relationship>(relationships);
            _allCompanions = new List<Companion>(allCompanions);
        }

        public IEnumerable<Companion> Analyze(Companion mainCompanion)
        {
            return WhoAreFine(_allCompanions, mainCompanion);
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
