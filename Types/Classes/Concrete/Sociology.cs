using System.Collections.Generic;
using Types.Classes.Abstract;
using Types.Enums;
using Modules;

namespace Types.Classes.Concrete {
    public class Sociology: AIntangible {
        public List<AAgent> Family;
        public List<AAgent> Friends;
        public List<AAgent> Lovers;
        public List<AAgent> FriendInterests;
        public List<AAgent> LoverInterests;
        public EOccupation Occupation;
        public EAmplitude Affluence;
        public List<EOrganization> Organizations;
        public List<EPastime> Pastimes;

        public Sociology() {
            this.Family = new List<AAgent>();
            this.Friends = new List<AAgent>();
            this.Lovers = new List<AAgent>();
            this.FriendInterests = new List<AAgent>();
            this.LoverInterests = new List<AAgent>();
            this.Occupation = (EOccupation) Utility.GetRandomEnumValue(new EOccupation());
            this.Affluence = (EAmplitude) Utility.GetRandomEnumValue(new EAmplitude());
            this.Organizations = new List<EOrganization>() { (EOrganization) Utility.GetRandomEnumValue(new EOrganization()) };
            this.Pastimes = new List<EPastime>() { (EPastime) Utility.GetRandomEnumValue(new EPastime()) };
        }
    }
}