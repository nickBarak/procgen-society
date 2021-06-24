using System.Collections.Generic;
using Types.Classes.Concrete;

namespace Types.Classes.Abstract {
    public abstract class AAgent: AEntity {
        public string Name;
        public Biology Biology;
        public Psychology Psychology;
        public Sociology Sociology;
        public Philosophy Philosophy;
        public List<Event> Memory;
    }
}