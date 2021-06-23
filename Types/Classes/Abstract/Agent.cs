using System.Collections.Generic;

namespace Types.Classes.Abstract {
    public abstract class AAgent: AEntity {
        public string Name;
        public Concrete.Biology Biology;
        public Concrete.Psychology Psychology;
        public Concrete.Sociology Sociology;
        public Concrete.Philosophy Philosophy;
        public List<Concrete.Event> Memory;
    }
}