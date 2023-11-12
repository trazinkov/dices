using System;
using System.ComponentModel;

namespace Dices {
    class Dices {
        // Glass with dices to throw dices
        private byte numbersOfEdges = 6;
        private byte numbersOfDices = 1;
        
        public byte NumbersOfEdges {
            get{
                return this.numbersOfEdges;
            }
            set{
                if (value < 4) {
                    this.numbersOfEdges = 4;
                    System.Console.WriteLine(
                        "      numbersOfEdges is to small. Set up 4");
                }
                if (value > 24) {
                    this.numbersOfEdges = 24;
                    System.Console.WriteLine(
                        "      numbersOfEdges is to big. Set up 24");
                }
            }
        }
        
        public byte NumbersOfDices {
            get{
                return this.numbersOfDices;
            }
            set
            {
                if (value < 1)
                {
                    this.numbersOfDices = 1;
                    System.Console.WriteLine(
                        "      numbersOfDices is to small. Set up 1");
                }
                else if (value > 20)
                {
                    this.numbersOfDices = 20;
                    System.Console.WriteLine(
                        "      numbersOfDices is to big. Set up 20");
                }
                else
                {
                    this.numbersOfDices = value;
                } 
            }
        }
        public Dices() {
            System.Console.WriteLine(
                "Dices object created without parameters");
            report();
        }
        public Dices(byte numbersOfEdges, byte numbersOfDices) {
            System.Console.WriteLine(
                "Dices object created with parameters ({0}, {1})"
                ,numbersOfEdges, numbersOfDices);
            this.NumbersOfEdges = numbersOfEdges;
            this.NumbersOfDices = numbersOfDices;
            report();
        }
        public void report(){
            System.Console.WriteLine(
                "  numbersOfEdges = " + this.NumbersOfEdges);
            System.Console.WriteLine(
                "  numbersOfDices = " + this.NumbersOfDices);
        }
        private short[] ThrowResults() {
            System.Console.WriteLine("Start throw");
            short[] results = new short[numbersOfDices];
            Random random = new Random();
            for (short i = 0; i < this.numbersOfDices; i++)
                {
                    results[i] = Convert.ToInt16(
                        // random.Next(1, this.numbersOfEdges));
                        random.Next(1, 7));
                    // System.Console.WriteLine("i = " + i);
                    // System.Console.WriteLine("results[i] = " + results[i]);
                }
            return results;
        }
        public void ShowResult()
        {
            string result = "   Result of throw -";
            foreach (short el in this.ThrowResults())
                {
                    result += " " + el + ' ';
                }
            System.Console.WriteLine(result);

        }

    }
}