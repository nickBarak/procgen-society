using Modules;
using System.Collections.Generic;
using Types.Enums;
using System.Linq;
using Types.Classes.Abstract;

namespace Types.Classes.Concrete {
    public class Psychology: AIntangible {
        public ETemperament Temperament;
        public EAmplitude Irritability;
        public EAmplitude MentalHealth;
        public EAmplitude Openness;
        public EAmplitude Conscientiousness;
        public EAmplitude Extraversion;
        public EAmplitude Agreeableness;
        public EAmplitude Negativity;

        public Psychology() {
            Utility.RandomizeFields(this, System.Enum.GetValues(typeof(EAmplitude)), "Temperament");
            this.Temperament = (ETemperament) Utility.GetRandomEnumValue(new ETemperament());
        }
    }
}