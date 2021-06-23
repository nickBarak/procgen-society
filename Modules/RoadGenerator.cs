using Direction = Types.Enums.CardinalDirection;
using Tile = Types.Classes.Concrete.Tile;

namespace Modules {
    public class RoadGenerator {
        private static Direction s_direction;
        private static System.Random s_random = new System.Random();
        
        public static Tile[,] GenerateRoads(Tile[,] graticule) {
            // - 4x4 chunks
            // - randomly select starting chunk from entire left side and first top adjacent and first bottom adjacent
            // - randomly select direction (of 2 viable)
            // - chunk can only be placed if at least 4 chunks away from any other chunk FIX
            // - at 6th chunk randomly select direction (except backwards)
            // - if dead end backtrack 1 chunk and try different direction
            // - connect some roads either after road gen or after adding buildings

            bool[,] chunkedMap = new bool[GraticuleGenerator.GraticuleSize/4, GraticuleGenerator.GraticuleSize/4];
            int startIndexSeed = s_random.Next(chunkedMap.Length + 2);
            int[] startIndex = (startIndexSeed <= chunkedMap.Length)
                                    ? new int[]{startIndexSeed, 0}
                                    : (startIndexSeed == chunkedMap.Length + 1)
                                        ? new int[]{0, 1}
                                        : new int[]{chunkedMap.Length, 1};
                        
            ChangeDirection();
            return new Tile[,]{};
        }

        private static void ChangeDirection() {
            s_direction = ((Direction[]) System.Enum.GetValues(typeof(Direction)))[s_random.Next(System.Enum.GetValues(typeof(Direction)).Length)];
        }
    }
}