using Types;
using Project;
using Tile = Types.Classes.Concrete.Tile;
using Tiles = Types.Enums.ETopography;
using Direction = Types.Enums.ECardinalDirection;
using System;
using System.Collections.Generic;

namespace Modules {
    public class GraticuleGenerator {
        public static int GraticuleSize=16;
        private static Tile[,] s_graticule;
        private static int s_longitude, s_latitude;
        // private static string s_north, s_west;
        private static readonly Tiles[] s_options = (Tiles[]) Enum.GetValues(typeof(Tiles));
        private static List<Tiles> s_filteredOptions = new List<Tiles>(s_options);
        private static Random s_random = new Random();

        
        public static Tile[,] GenerateGraticule(List<Types.Classes.Abstract.AAgent> agents=null) {
            InitializeGraticule();

            s_graticule = RoadGenerator.GenerateRoads(s_graticule);
            s_graticule = BuildingGenerator.GenerateBuildings(s_graticule);
            s_graticule = PeripheralTopographyGenerator.GeneratePeripheralTopography(s_graticule);

            return s_graticule;
        }

        private static void InitializeGraticule() {
            s_graticule = new Tile[GraticuleSize, GraticuleSize];
            for (s_latitude=0; s_latitude<GraticuleSize; s_latitude++) {
                for (s_longitude=0; s_longitude<GraticuleSize; s_longitude++) {
                    s_graticule[s_latitude, s_longitude] = new Tile(new int[2]{s_latitude, s_longitude});
                }
            }
        }

        private static void FilterOptions() {
            
            // for (s_latitude; s_latitude<GraticuleSize; s_latitude++) {
            //     for (s_longitude; s_longitude<GraticuleSize; s_longitude++) {
            //         s_north = graticule[s_latitude+1][s_longitude];
            //         s_west = graticule[s_latitude][s_longitude-1];
            //         FilterOptions();
            //         graticule[s_latitude][s_longitude] = s_filteredOptions[s_random.Next(s_options.Length)];
            //     }
            // }


            // switch (s_north) {
            //     case Tiles.ROAD:
            //     case Tiles.HOUSE:
            //     case Tiles.STORE:
            //     case Tiles.GRASS:
            //     case Tiles.STREET_LIGHT:
            //     case Tiles.TREE:
            //     case Tiles.BUSH:
            //     default: throw new Exception("Invalid Topography");
            // }

            // switch (s_west) {
            //     case Tiles.ROAD:
            //     case Tiles.HOUSE:
            //     case Tiles.STORE:
            //     case Tiles.GRASS:
            //     case Tiles.STREET_LIGHT:
            //     case Tiles.TREE:
            //     case Tiles.BUSH:
            //     default: throw new Exception("Invalid Topography");
            // }
        }
    }
}