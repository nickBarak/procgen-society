using Types;
using Project;
using Database;
using System;
using Tile = Types.Classes.Concrete.Tile;
using Human = Types.Classes.Concrete.Human;
using AAgent = Types.Classes.Abstract.AAgent;
using Sociology = Types.Classes.Concrete.Sociology;
using System.Collections.Generic;

namespace Modules {
    public class AgentGenerator {
        private static readonly string[] s_relationshipSets = new string[]{"Friends", "Lovers", "Enemies", "FriendInterests", "LoverInterests"};
        private static Random s_random = new Random();
        private static List<AAgent> s_agents;
        private static List<Human> s_humans;

        public static List<AAgent> GenerateAgents() {
            s_agents = new List<AAgent>();
            s_humans = new List<Human>();

            GenerateHumans();
            SetSocialRelationships();

            return s_agents;
        }

        private static void GenerateHumans() {
            for (int i=GraticuleGenerator.GraticuleSize/4; i>0; i--)
                s_humans.Add(new Human());
            s_agents.AddRange(s_humans);
        }

        private static void SetSocialRelationships() {
            foreach (Human human in s_humans) {
                foreach(string relationshipSet in s_relationshipSets) {
                    System.Reflection.FieldInfo fieldInfo = typeof(Sociology).GetField(relationshipSet);
                    fieldInfo.SetValue(human.Sociology, new AAgent[]{s_humans[s_random.Next(s_humans.Count)]});
                }
            }
        }
    }
}