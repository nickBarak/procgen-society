using Modules;
using System.Collections.Generic;
using Types.Enums;
using System.Linq;
using System;
using Types.Classes.Abstract;

namespace Types.Classes.Concrete {
    public class Philosophy: AIntangible {
        public ESchoolOfThought SchoolOfThought;
        public List<EAmbition> Ambitions;
        public EAmplitude Impressionability;
        public EAmplitude DeterminismOverWill;
        public EAmplitude PessimismOverOptimism;
        public EAmplitude CausalityOverTeleologicality;
        public EAmplitude ConsciousnessOverUnconsciousness;
        public EAmplitude NatureOverNurture;
        public EAmplitude UniquenessOverSimilarity;
        public EAmplitude SelfActualization;

        public Philosophy() {
            Utility.RandomizeFields(this, Enum.GetValues(typeof(EAmplitude)), "SchoolOfThought", "Ambitions");
            this.SchoolOfThought = (ESchoolOfThought) Utility.GetRandomEnumValue(new ESchoolOfThought());
            this.Ambitions = new List<EAmbition>() { (EAmbition) Utility.GetRandomEnumValue(new EAmbition()) };
        }
    }
}