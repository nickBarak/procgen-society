using Types;
using Project;
using Database;
using System;
using Tile = Types.Classes.Concrete.Tile;
using Tree = Types.Classes.Concrete.Tree;
using StreetLight = Types.Classes.Concrete.StreetLight;
using Bush = Types.Classes.Concrete.Bush;

namespace Modules {
    public class PeripheralTopographyGenerator {
        private static Tile[,] s_modifiedGraticule;

        public static Tile[,] GeneratePeripheralTopography(Tile[,] graticule) {
            s_modifiedGraticule = (Tile[,]) graticule.Clone();

            GenerateTrees();
            GenerateStreetLights();
            GenerateBushes();

            return s_modifiedGraticule;
        }

        private static void GenerateTrees() {
            
        }

        private static Tree GenerateTree() {
            string HumanName = Database.Names.Data[new Random().Next(Database.Names.Data.Count)].Text;
            Tree tree = new Tree();
            return tree;
        }

        private static void GenerateStreetLights() {
            
        }

        private static StreetLight GenerateStreetLight() {
            string HumanName = Database.Names.Data[new Random().Next(Database.Names.Data.Count)].Text;
            StreetLight streetLight = new StreetLight();
            return streetLight;
        }

        private static void GenerateBushes() {

        }

        private static Bush GenerateBush() {
            string HumanName = Database.Names.Data[new Random().Next(Database.Names.Data.Count)].Text;
            Bush bush = new Bush();
            return bush;
        }
    }
}