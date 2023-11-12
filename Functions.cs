using System;
namespace Dices{
    public class MassiveUnits {
        public static void printMassivaAsLine(
            string[] strings, 
            string prefix) {
                string resultString = "";
                foreach(string stringElement in strings) {
                    resultString += stringElement;
                    resultString += ' ';
                }
                System.Console.WriteLine(prefix + resultString.Trim());
        }
        public static void printMassivaAsColumn(
            string[] strings,
            string prefix){
                foreach(string stringElement in strings) {
                    System.Console.WriteLine(prefix + stringElement);
                }
            }

    }
}