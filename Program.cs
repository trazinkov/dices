using System;

namespace Dices {
    class Program{
        static void Main(){
            System.Console.WriteLine("------------------------------------------------------------");
            // Dices glass_test = new Dices();
            // Dices glass_test2 = new Dices(6,5);
            // glass_test2.ShowResult();
            // Intriga.TimeThread();
            string[] testStrings = new string[] {"one", "two", "three"};
            Intriga testIntriga = new Intriga(testStrings, 2000);
            testIntriga.printIntriga("    ");
        }
    }
}