using System.Collections.Generic;
using Types.Classes.Abstract;
using Types.Enums;
using Modules;
using System;
using System.Reflection;

namespace Types.Classes.Concrete {
    public class Sociology: AIntangible {
        private AAgent[] _friends;
        public AAgent[] Friends;
        private AAgent[] _lovers;
        public AAgent[] Lovers;
        private AAgent[] _enemies;
        public AAgent[] Enemies;
        private AAgent[] _friendInterests;
        public AAgent[] FriendInterests;
        private AAgent[] _loverInterests;
        public AAgent[] LoverInterests;
        public EOccupation Occupation;
        public EAmplitude Affluence;
        public List<EOrganization> Organizations;
        public List<EPastime> Pastimes;

        public Sociology() {
            this.Friends = new AAgent[]{};
            this.Lovers = new AAgent[]{};
            this.Enemies = new AAgent[]{};
            this.FriendInterests = new AAgent[]{};
            this.LoverInterests = new AAgent[]{};
            this.Occupation = (EOccupation) Utility.GetRandomEnumValue(new EOccupation());
            this.Affluence = (EAmplitude) Utility.GetRandomEnumValue(new EAmplitude());
            this.Organizations = new List<EOrganization>() { (EOrganization) Utility.GetRandomEnumValue(new EOrganization()) };
            this.Pastimes = new List<EPastime>() { (EPastime) Utility.GetRandomEnumValue(new EPastime()) };
        }

        private AAgent FindContradiction(AAgent[] agents, params string[] exclusions) {
            List<AAgent> seenAgents = new List<AAgent>();
            return Array.Find(agents, agent => {
                if (agent.Equals(this)) return true;
                if (seenAgents.Find(seenAgent => seenAgent.Equals(agent)) != null) return true;
                seenAgents.Add(agent);
                List<AAgent> list = new List<AAgent>();

                foreach (string exclusion in exclusions) {
                    AAgent[] exclusiveArray = (AAgent[]) typeof(Sociology).GetField(exclusion).GetValue(agent);
                    list.Add(Array.Find(exclusiveArray, exclusiveMember => exclusiveMember.Equals(agent)));
                }
                
                return list.Find(element => element != null) != null;
            });
        }

        public AAgent[] GetFriends() { return this._friends; }

        public void SetFriends(AAgent[] friends) {
            if (FindContradiction(friends, "Lovers", "FriendInterests", "Enemies") == null)
                this._friends = friends;
        }
        
        public AAgent[] GetLovers() { return this._lovers; }

        public void SetLovers(AAgent[] lovers) {
            if (FindContradiction(lovers, "LoverInterests", "Enemies") == null)
                this._lovers = lovers;
        }

        public AAgent[] GetEnemies() { return this._enemies; }

        public void SetEnemies(AAgent[] enemies) {
            if (FindContradiction(enemies, "LoverInterests", "FriendInterests") == null)
                this._enemies = enemies;
        }

        public AAgent[] GetFriendInterests() { return this._friendInterests; }

        public void SetFriendInterests(AAgent[] friendInterests) {
            if (FindContradiction(friendInterests, "Friends", "Enemies") == null)
                this._friendInterests = FriendInterests;
        }

        public AAgent[] GetLoverInterests() { return this._loverInterests; }

        public void SetLoverInterests(AAgent[] loverInterests) {
            if (FindContradiction(loverInterests, "Lovers", "Enemies") == null)
                this._loverInterests = loverInterests;
        }
    }
}