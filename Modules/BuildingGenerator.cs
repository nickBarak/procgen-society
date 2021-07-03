using Direction = Types.Enums.ECardinalDirection;
using System;
using Tile = Types.Classes.Concrete.Tile;

namespace Modules {
    public class BuildingGenerator {
        private static Direction s_direction;
        private static Random s_random = new Random();
        private static Tile[,] s_modifiedGraticule;

        public static Tile[,] GenerateBuildings(Tile[,] graticule) {
            s_modifiedGraticule = (Tile[,]) graticule.Clone();

            GenerateResidentialBuildings();
            GenerateCommercialBuildings();

            return s_modifiedGraticule;
        }
        
        private static void GenerateResidentialBuildings() {
            // - 4x4 chunks
        }

        private static bool[,] GenerateResidentialBuilding() {
            return new bool[,]{};
        }

        private static void GenerateCommercialBuildings() {
        }

        private static bool[,] GenerateCommercialBuilding() {
            return new bool[,]{};
        }

        private static void ChangeDirection() {
            s_direction = ((Direction[]) Enum.GetValues(typeof(Direction)))[s_random.Next(Enum.GetValues(typeof(Direction)).Length)];
        }
    }
}