using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountBladeCompanions.Data
{
    class Companion : IEquatable<Companion>
    {
        public string Name { get; set; }

        public Companion(string name)
        {
            Name = name;
        }

        public bool Equals(Companion other)
        {
            return Name == other.Name;
        }        
    }
}
