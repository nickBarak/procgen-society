Drop if north
    case "R":
        if (LookNorth(4).FindAll(tile => tile == "R").Length != 4) {
            filteredOptions = new string[]{"R"};
            break;
        }
    case "H":
    case "S":
    case "G":
    case "L":
    case "T":
    case "B":


Drop if west
    case "R":
        if (LookWest(4).FindAll(tile => tile == "R").Length != 4) {
            filteredOptions = new string[]{"R"};
            break;
        }
    case "H":
        if (LookWest(6).FindAll(tile => tile == "H").Length != 6) {
            filteredOptions = new string[]{"H"}
            break;
        }
    case "S":
        if (LookWest(10).FindAll(tile => tile == "S").Length != 10) {
            filteredOptions = new string[]{"S"}
            break;
        }
    case "L":
    case "T":
    case "B":




if tile is not null
    skip
else
    





