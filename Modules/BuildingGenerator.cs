using Direction = Types.Enums.ECardinalDirection;
using System;
using Tile = Types.Classes.Concrete.Tile;

namespace Modules {
    public class BuildingGenerator {
        private static Direction s_direction;
        private static Random s_random = new Random();

        public static Tile[,] GenerateBuildings(Tile[,] graticule) {
            Tile[,] modifiedGraticule = (Tile[,]) graticule.Clone();
            modifiedGraticule = GenerateResidentialBuildings(graticule);
            modifiedGraticule = GenerateCommercialBuildings(modifiedGraticule);
            return modifiedGraticule;
        }
        
        public static Tile[,] GenerateResidentialBuildings(Tile[,] graticule) {
            // - 4x4 chunks
            return new Tile[,]{};
        }

        public static bool[,] GenerateResidentialBuilding() {
            return new bool[,]{};
        }

        public static Tile[,] GenerateCommercialBuildings(Tile[,] graticule) {
            return new Tile[,]{};
        }

        public static bool[,] GenerateCommercialBuilding() {
            return new bool[,]{};
        }

        private static void ChangeDirection() {
            s_direction = ((Direction[]) Enum.GetValues(typeof(Direction)))[s_random.Next(Enum.GetValues(typeof(Direction)).Length)];
        }
    }
}