using System.Collections.Generic;
using Types.Classes.Abstract;

namespace Types.Classes.Concrete {
    public class Human: AAgent {
        public Human(Database.Names.Record nameRecord=null) {
            this.Biology = new Biology();
            this.Psychology = new Psychology();
            this.Sociology = new Sociology();
            this.Philosophy = new Philosophy();
            this.Memory = new List<Event>();
            
            if (nameRecord == null) nameRecord = Database.Names.Data[new System.Random().Next(Database.Names.Data.Count)];
            this.Name = nameRecord.Text;
            this.Biology.IsMale = nameRecord.IsMale;
        }
    }
}