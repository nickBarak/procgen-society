using System.Collections.Generic;

namespace Database {
    public class Names {
        public class Record {
            public string Text;
            public bool IsMale;

            public Record(string text, bool isMale) {
                this.Text = text;
                this.IsMale = isMale;
            }
        }

        public static List<Record> Data = new List<Record>() {
            new Record("James", true),
            new Record("Jeremy", true),
            new Record("John", true),
            new Record("Jane", false),
            new Record("Jordan", false),
            new Record("Jules", false),
        };
    }
}