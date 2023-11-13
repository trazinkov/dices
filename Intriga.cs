using System;
using System.Threading;

namespace Dices {
    class Intriga {
        // Return results of throw dices with time,
        //or another string massive
        
        private int timeSleep;
        private string[] strings;
        public static void TimeThread(){
            System.Console.WriteLine("Test thread");
            Thread.Sleep(3000);
            System.Console.WriteLine("After sleep");
        }
        public Intriga(string[] strings, int timeSleep) {
            this.strings = strings;
            this.timeSleep = timeSleep;
            System.Console.WriteLine(
                "Constructor: Intriga instance initialized:");
            System.Console.Write(
                "  * Strings = ");
            MassiveUnits.printMassiv(this.strings);
            System.Console.WriteLine("  * timeSleep = " + timeSleep);
            // MassiveUnits.printMassiv(
            //     new string [] {"12", "13", "14"},
            //     "   ",
            //     EPrintingTypes.Line);
            // MassiveUnits.printMassiv(
            //     new string [] {"12", "13", "14"},
            //     "       ",
            //     EPrintingTypes.Column);
        }
        public void printIntriga(string prefix){
            foreach (string stringElement in this.strings){
                Thread.Sleep(this.timeSleep);
                System.Console.WriteLine(prefix + stringElement);
                
            }
        }
    }
}