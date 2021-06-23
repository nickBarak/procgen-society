using System;
using Modules;
using Types;
using World = Types.Classes.Concrete.World;
using Human = Types.Classes.Concrete.Human;

namespace Project {
    public class Game {
        public static World World;
        public static World TargetState;
        public static Human Player;
        private static string[] s_confirmationalInput = new string[]{"y","Y","yes","Yes","yeah","Yeah","mhm","Mhm","ye","yee","sure","Sure","true","True"};
        private static string s_input;

        public static void Main(string[] args) {
            Out("Running Procgen Society");
            System.Threading.Thread.Sleep(1200);

            Console.Write("Generating world");
            World = new World();

            Console.Write("Establishing objectives");
            GenerateTargetState();

            Out("Game ready. Press any key to begin.");
            Console.ReadKey(true);

            Console.Write("\nWelcome. What is your name? ");
            string playerName = Console.ReadLine();

            Console.Write("Are you male? ");
            s_input = Console.ReadLine();
            bool playerIsMale = ConfirmInput();

            Database.Names.Record playerNameRecord = new Database.Names.Record(playerName, playerIsMale);
            do {
                Player = new Human(playerNameRecord);
                Out(string.Format("\nPresenting data generated for player:\n", playerName) + Utility.Serialize(Player));
                Console.Write("\nWould you like to re-roll? ");
                s_input = Console.ReadLine();
            } while (ConfirmInput());

            Out("\nThank you for playing.");
            System.Threading.Thread.Sleep(900);
            Out("Goodbye.");
            System.Threading.Thread.Sleep(500);
        }

        public static void Out(params string[] strArr) {
            foreach (string s in strArr) Console.Write(s);
            Console.WriteLine();
        }

        private static void GenerateTargetState() {
            TargetState = World;
            System.Threading.Thread.Sleep(800);
            Console.Write(".");
            System.Threading.Thread.Sleep(800);
            Console.Write(".");
            System.Threading.Thread.Sleep(800);
            Console.Write(".\n");
        }

        private static bool ConfirmInput() {
            return (Array.Find(s_confirmationalInput, answer => answer.Equals(s_input)) != null);
        }
    }
}