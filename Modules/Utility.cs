using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections;

namespace Modules {
    public class Utility {
        public static void RandomizeFields(object instance, Array bank, params string[] exclusions) {
            Random random = new Random();
            foreach (System.Reflection.FieldInfo field in instance.GetType().GetFields()) {
                if (Array.Find(exclusions, exclusion => exclusion.Equals(field.Name)) == null)
                    field.SetValue(instance, bank.GetValue(random.Next(bank.Length)));
            }
        }

        public static object GetRandomEnumValue(Enum enumType) {
            Array bank = Enum.GetValues(enumType.GetType());
            return bank.GetValue(new Random().Next(bank.Length));
        }

        public static string Serialize(object instance, string indent="") {
            if (instance == null) return "null";
            Type type = instance.GetType();
            if (type.IsPrimitive || type == typeof(string) || type.IsEnum) return instance.ToString();
            if (typeof(IEnumerable).IsAssignableFrom(type)) return Serialize((IEnumerable) instance);
            return type.GetFields().Aggregate("", 
                (accumulator, current) => accumulator + String.Format("\n{0}{1}: {2}", indent, current.Name, Serialize(current.GetValue(instance), indent + "  ")));
        }

        public static string Serialize(IEnumerable enumerable, string indent="") {
            string result = "";
            foreach(object obj in enumerable) result += ", " + Serialize(obj);
            return (result.Length > 0) ? result.Substring(2) : "None";
        }
    }
}