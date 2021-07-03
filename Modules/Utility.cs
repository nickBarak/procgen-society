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

        public static string SerializeAsJSON(object instance, string indent="  ", List<object> references=null) {
            if (instance == null) return "null";
            if (references == null) references = new List<object>();
            List<object> newReferences = new List<object>(references){instance};

            Type instanceType = instance.GetType();
            if (instanceType == typeof(bool)) return instance.ToString().ToLower();
            if (new Type[]{typeof(byte), typeof(short), typeof(int), typeof(long), typeof(float), typeof(double), typeof(decimal)}.Any(type => type == instanceType))
                return instance.ToString();
            if (instanceType.IsPrimitive || instanceType.IsEnum || instanceType == typeof(string))
                return "\"" + instance.ToString() + "\"";
            if (references.Any(reference => object.ReferenceEquals(instance, reference)))
                return "\"circular reference\"";
            if (typeof(IEnumerable).IsAssignableFrom(instanceType)) {
                return SerializeAsJSON(
                    (IEnumerable) instance,
                    indent,
                    newReferences
                );
            }

            return instanceType.GetFields().Aggregate("", 
                (accumulator, current) => accumulator + string.Format(
                    "{0}\"{1}\": {2},\n",
                    indent,
                    current.Name,
                    SerializeAsJSON(
                        current.GetValue(instance),
                        indent+"  ",
                        newReferences
                    )
                ),
                (accumulator) => (accumulator.Length > 0)
                                    ? string.Format("{{\n{0}{1}}}", accumulator, indent.Substring(0, indent.Length-2))
                                    : "{}"
            );
        }

        public static string SerializeAsJSON(IEnumerable enumerable, string indent, List<object> references) {
            string result = "";
            foreach (dynamic element in enumerable)
                result += SerializeAsJSON(element, indent, references) + ",\n";
            return (result.Length > 0)
                        ? string.Format("[\n{0}{1}\n{2}]", indent, result.Substring(0, result.Length-1), indent.Substring(0, indent.Length-2))
                        : "[]";
        }
    }
}