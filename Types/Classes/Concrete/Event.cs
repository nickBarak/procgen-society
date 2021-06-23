using System.Collections.Generic;
using Types.Enums;
using Types.Classes.Abstract;

namespace Types.Classes.Concrete {
    public class Event: AIntangible {
        public int Time;
        public int[] Coordinates;
        public EAction Action;
        public AEntity Actor;
        public AEntity Recipient;
        public List<string> Consequences;
    }
}