using Types.Classes.Abstract;

namespace Types.Classes.Concrete {
    public class Tile {
        public int[] Coordinates;
        public ATopography Topography;
        public AEntity Occupant;
        public int TimeLastOccupied;

        public Tile(int[] coordinates, ATopography topography=null) {
            this.Coordinates = coordinates;
            this.Topography = (topography != null) ? topography : new Grass();
        }
    }
}