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
        public static Tile[,] GeneratePeripheralTopography(Tile[,] graticule) {
            Tile[,] modifiedGraticule = (Tile[,]) graticule.Clone();
            modifiedGraticule = GenerateTrees(modifiedGraticule);
            modifiedGraticule = GenerateStreetLights(modifiedGraticule);
            modifiedGraticule = GenerateBushes(modifiedGraticule);
            return modifiedGraticule;
        }

        public static Tile[,] GenerateTrees(Tile[,] graticule) {
            return new Tile[,]{};
        }

        public static Tree GenerateTree() {
            string HumanName = Database.Names.Data[new Random().Next(Database.Names.Data.Count)].Text;
            Tree tree = new Tree();
            return tree;
        }

        public static Tile[,] GenerateStreetLights(Tile[,] graticule) {
            return new Tile[,]{};
        }

        public static StreetLight GenerateStreetLight() {
            string HumanName = Database.Names.Data[new Random().Next(Database.Names.Data.Count)].Text;
            StreetLight streetLight = new StreetLight();
            return streetLight;
        }

        public static Tile[,] GenerateBushes(Tile[,] graticule) {
            return new Tile[,]{};
        }

        public static Bush GenerateBush() {
            string HumanName = Database.Names.Data[new Random().Next(Database.Names.Data.Count)].Text;
            Bush bush = new Bush();
            return bush;
        }
    }
}