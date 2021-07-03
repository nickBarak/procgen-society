using System.Collections.Generic;
using Types.Classes.Abstract;
using Modules;

namespace Types.Classes.Concrete {
    public class World: AIntangible {
        public Tile[,] Graticule;
        public List<AAgent> Agents;
        public List<Event> Chronology;

        public World() {
            this.Agents = Modules.AgentGenerator.GenerateAgents();
            this.Graticule = Modules.GraticuleGenerator.GenerateGraticule(this.Agents);
            System.Threading.Thread.Sleep(750);
            System.Console.Write(".");
            System.Threading.Thread.Sleep(750);
            System.Console.Write(".");
            System.Threading.Thread.Sleep(750);
            System.Console.Write(".\n");
        }
    }
}