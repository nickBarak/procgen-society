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
            List<Human> humans = GenerateHumans();
            agents.AddRange(humans);

            Random random = new Random();

            foreach (Human human in humans) {
                human.Sociology.Family = new AAgent[]{};
                human.Sociology.Friends = new AAgent[]{};
                human.Sociology.Lovers = new AAgent[]{};
                human.Sociology.Enemies = new AAgent[]{};
                human.Sociology.FriendInterests = new AAgent[]{};
                human.Sociology.LoverInterests = new AAgent[]{};
            }

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