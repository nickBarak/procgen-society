using Modules;
using System.Collections.Generic;
using Types.Enums;
using System.Linq;
using System;
using Types.Classes.Abstract;

namespace Types.Classes.Concrete {
    public class Biology: AIntangible {
        public bool IsMale;
        public EAmplitude Masculinity;
        public EAmplitude Age;
        public EAmplitude Height;
        public EAmplitude Fitness;
        public EAmplitude Attractiveness;
        public EAmplitude Humor;
        public EAmplitude Fertility;
        public EAmplitude Tenacity;
        public EAmplitude Dexterity;
        public EAmplitude Intellect;
        public EAmplitude Curiosity;
        public EAmplitude Charisma;
        public EAmplitude Satiation;
        public EAmplitude PhysicalHealth;

        public Biology() {
            Utility.RandomizeFields(this, Enum.GetValues(typeof(EAmplitude)), "IsMale");
        }
    }
}