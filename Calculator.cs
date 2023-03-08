using System;

namespace BasicCalculator
{   
    class Calculator
    {
        // See https://aka.ms/new-console-template for more information
        static void Main(string[] args)
        {   
            int firstNumber;
            int secondNumber;
            string OperatorOptions = {"+", "-", "*", "/", "%"};
            Console.WriteLine("Kalkulator sederhana");
            Console.WriteLine(firstNumber = "Masukkan angka pertama : ");
            Console.WriteLine(secondNumber = "Masukkan angka kedua : ");
            Console.WriteLine("Pilh operator : " + OperatorOptions);
            if(firstNumber != "" && secondNumber != "" )
            {
                switch(OperatorOptions)
                {
                    case OperatorOptions{0} : NumberAndOperator(CalulateValue);
                        break;
                    case OperatorOptions{1} : NumberAndOperator(CalulateValue);
                        break;
                    case OperatorOptions{2} : 
                        break;
                    case OperatorOptions{3} : 
                        break;
                    case OperatorOptions{4} : 
                        break;
                }
            }
            SubtracNumber(CalulateValue);
            Console.ReadKy();
        }

        static SumNumber(secondNumber, secondNumber)
        {   
            return secondNumbeer + firstNumber;
            // switch(CalulateValue)
            // {   
            //     case !"" : 
            //     case '+' :  Console.WriteLine(secondNumbeer + firstNumber);
            //                 secondNumbeer + firstNumber;
            //     break;    
            // }
        }
        static SubtracNumber(secondNumber, secondNumber)
        {   
            return secondNumbeer + firstNumber;
            // switch(CalulateValue)
            // {   
            //     case !"" : 
            //     case '+' :  Console.WriteLine(secondNumbeer + firstNumber);
            //                 secondNumbeer + firstNumber;
            //     break;    
            // }
        }
    }
}
