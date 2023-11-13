using System;
namespace Dices{
    public class MassiveUnits {
        // Utils to working with massives
        public static void printMassiv(
            // Print massive in line or in column
            //with prefix in the terminal
            string[] strings, 
            string prefix,
            EPrintingTypes printingType) {
                if (printingType == EPrintingTypes.Line) {
                    string resultString = "";
                    foreach(string stringElement in strings) {
                        resultString += stringElement;
                        resultString += ' ';
                    }
                    System.Console.WriteLine(
                        prefix + resultString.Trim());
                }
                else if (printingType == EPrintingTypes.Column){
                    foreach(string stringElement in strings) {
                        System.Console.WriteLine(
                            prefix + stringElement);
                    }
                }
            }
        public static void printMassiv(string[] strings) {
                string resultString = "";
                foreach(string stringElement in strings) {
                    resultString += stringElement;
                    resultString += ' ';
                }
                System.Console.WriteLine(resultString.Trim());
            }
    }
    public enum EPrintingTypes {Line, Column}
}


// using System;
// namespace Dices{
//     public class MassiveUnits {
//         public static void printMassivaAsLine(
//             string[] strings, 
//             string prefix) {
//                 string resultString = "";
//                 foreach(string stringElement in strings) {
//                     resultString += stringElement;
//                     resultString += ' ';
//                 }
//                 System.Console.WriteLine(prefix + resultString.Trim());
//         }
//         public static void printMassivaAsColumn(
//             string[] strings,
//             string prefix){
//                 foreach(string stringElement in strings) {
//                     System.Console.WriteLine(prefix + stringElement);
//                 }
//             }

//     }
// }


// using System;
// namespace Dices{
//     public class MassiveUnits {
//         public string[] strings;
//         public string prefix;
//         public MassiveUnits(string[] strings, string prefix){
//             this.strings = strings;
//             this.prefix = prefix;
//         }
//         public void printMassiv(
//             EPrintingTypes printingType,
//             string prefix ) {
//                 if (printingType == EPrintingTypes.Line) {
//                     string resultString = "";
//                     foreach(string stringElement in this.strings) {
//                         resultString += stringElement;
//                         resultString += ' ';
//                     }
//                     System.Console.WriteLine(prefix + resultString.Trim());
//                 }
//                 else if (printingType == EPrintingTypes.Column){
//                     foreach(string stringElement in this.strings) {
//                         System.Console.WriteLine(prefix + stringElement);
//                     }
//                 }
//             }
//     }