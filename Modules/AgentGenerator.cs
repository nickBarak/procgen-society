using Types;
using Project;
using Database;
using System;
using Tile = Types.Classes.Concrete.Tile;
using Human = Types.Classes.Concrete.Human;
using AAgent = Types.Classes.Abstract.AAgent;
using System.Collections.Generic;

namespace Modules {
    public class AgentGenerator {
        public static List<AAgent> GenerateAgents() {
            List<AAgent> agents = new List<AAgent>();
            agents.AddRange(GenerateHumans());
            return agents;
        }

        public static List<Human> GenerateHumans() {
            List<Human> humans = new List<Human>();
            for (int i=GraticuleGenerator.GraticuleSize/4; i>0; i++)
                humans.Add(new Human());
            return humans;
        }
    }
}