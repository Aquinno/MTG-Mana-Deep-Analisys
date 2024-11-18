namespace ManaDeepAnalisys {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("======================================");
            Console.WriteLine("          MANA DEEP ANALISYS          ");
            Console.WriteLine("======================================");
            Console.WriteLine("                    - Author: @Aquinno");
            Console.WriteLine("                    - Version: 1.0.0");
            Console.WriteLine("======================================");
            Console.Write("Enter the 1º Mana Color: ");
            string color1 = Console.ReadLine();
            Console.Write("Enter the 2º Mana Color: ");
            string color2 = Console.ReadLine();
            Console.WriteLine("======================================");
            Console.Write($">Especific {color1} Mana Sources: ");
            int source1 = int.Parse(Console.ReadLine());
            Console.Write($">Especific {color2} Mana Sources: ");
            int source2 = int.Parse(Console.ReadLine());
            Console.Write($">Colorless Mana Sources: ");
            int colorless = int.Parse(Console.ReadLine());
            Console.Write(">Multicolored sources\nEx)\n-Commander's Sphere\n-Elvish Mystical\n-Arcane Signet\n-Dual Lands\n \nType here: ");
            int multiSource = int.Parse(Console.ReadLine());
            Console.WriteLine("======================================");
            Console.WriteLine("All possible Mana Combinations: ");
            Console.WriteLine("======================================");
            Console.WriteLine(" ");
            for (int i = 0; i <= multiSource; i++) {
                Console.WriteLine($"Combination #{i + 1}");
                Console.WriteLine($"{color1}: {source1 + multiSource - i}");
                Console.WriteLine($"{color2}: {source2 + i}");
                Console.WriteLine($"Colorless: {colorless}");
                Console.WriteLine("======================================");
            }
        }
    }
}
