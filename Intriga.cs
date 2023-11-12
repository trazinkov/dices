using System;
using System.Threading;

namespace Dices {
    class Intriga {
        // Return results of throw dices with time
        
        private int timeSleep;
        private string[] strings;
        public static void TimeThread(){
            System.Console.WriteLine("Test thread");
            Thread.Sleep(3000);
            System.Console.WriteLine("After sleep");
        }
        public Intriga(string[] strings, int timeSleep) {
            System.Console.WriteLine("Constructor: Intriga instance initialized");
            System.Console.WriteLine("  Strings = " + strings);
            System.Console.WriteLine("  timeSleep = " + timeSleep);
            MassiveUnits.printMassivaAsLine(
                new string [] {"12", "13", "14"},
                "   ");
            MassiveUnits.printMassivaAsColumn(
                new string [] {"12", "13", "14"},
                "       ");
            this.strings = strings;
            this.timeSleep = timeSleep;
        }
    }
}