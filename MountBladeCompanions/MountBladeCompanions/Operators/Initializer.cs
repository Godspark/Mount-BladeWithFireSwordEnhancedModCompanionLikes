using MountBladeCompanions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountBladeCompanions.Operators
{
    class Initializer
    {
        public IEnumerable<Companion> GetAllCompanions()
        {
            var list = new List<Companion>();
            list.Add(new Companion("Algirdas"));
            list.Add(new Companion("Bakhyt"));
            list.Add(new Companion("Fatima"));
            list.Add(new Companion("Fedot"));
            list.Add(new Companion("Ingri"));
            list.Add(new Companion("Karlsson"));
            list.Add(new Companion("Nogai"));
            list.Add(new Companion("Oksana"));
            list.Add(new Companion("Priest Spasokukotsky"));
            list.Add(new Companion("Sarabun"));
            list.Add(new Companion("Tepes"));
            list.Add(new Companion("Varvara"));
            list.Add(new Companion("Victor De La Buscador"));
            list.Add(new Companion("Yelisei"));

            return list;
        }


        public IEnumerable<Relationship> GetInitialData()
        {
            var algirdas = new Companion("Algirdas");
            var bakhyt = new Companion("Bakhyt");
            var fatima = new Companion("Fatima");
            var fedot = new Companion("Fedot");
            var ingri = new Companion("Ingri");
            var karlsson = new Companion("Karlsson");
            var nogai = new Companion("Nogai");
            var oksana = new Companion("Oksana");
            var priestSpasokukotsky = new Companion("Priest Spasokukotsky");
            var sarabun = new Companion("Sarabun");
            var tepes = new Companion("Tepes");
            var varvara = new Companion("Varvara");
            var victorDeLaBuscador = new Companion("Victor De La Buscador");
            var yelisei = new Companion("Yelisei");
            
            var list = new List<Relationship>();
            list.Add(new Relationship(algirdas, fedot, Relation.Dislikes));
            list.Add(new Relationship(algirdas, nogai, Relation.Dislikes));
            list.Add(new Relationship(bakhyt, fatima, Relation.Dislikes));
            list.Add(new Relationship(bakhyt, varvara, Relation.Dislikes));
            list.Add(new Relationship(fatima, nogai, Relation.Dislikes));
            list.Add(new Relationship(fatima, oksana, Relation.Dislikes));
            list.Add(new Relationship(fedot, bakhyt, Relation.Dislikes));
            list.Add(new Relationship(fedot, oksana, Relation.Dislikes));
            list.Add(new Relationship(ingri, sarabun, Relation.Dislikes));
            list.Add(new Relationship(ingri, victorDeLaBuscador, Relation.Dislikes));
            list.Add(new Relationship(karlsson, algirdas, Relation.Dislikes));
            list.Add(new Relationship(karlsson, tepes, Relation.Dislikes));
            list.Add(new Relationship(nogai, fatima, Relation.Dislikes));
            list.Add(new Relationship(nogai, yelisei, Relation.Dislikes));
            list.Add(new Relationship(oksana, karlsson, Relation.Dislikes));
            list.Add(new Relationship(oksana, victorDeLaBuscador, Relation.Dislikes));
            list.Add(new Relationship(sarabun, algirdas, Relation.Dislikes));
            list.Add(new Relationship(sarabun, varvara, Relation.Dislikes));
            list.Add(new Relationship(tepes, oksana, Relation.Dislikes));
            list.Add(new Relationship(tepes, priestSpasokukotsky, Relation.Dislikes));
            list.Add(new Relationship(varvara, ingri, Relation.Dislikes));
            list.Add(new Relationship(varvara, tepes, Relation.Dislikes));
            list.Add(new Relationship(victorDeLaBuscador, karlsson, Relation.Dislikes));
            list.Add(new Relationship(victorDeLaBuscador, sarabun, Relation.Dislikes));
            list.Add(new Relationship(yelisei, ingri, Relation.Dislikes));

            return list;
        }
    }
}
