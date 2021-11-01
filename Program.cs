using System;

namespace consoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // intro for the user
            Console.WriteLine(" Welcome to this simple Calculator \n " +
                "Enter the First Oprand: ");
       
            // storing the first operand for the operation 
            int num1 = Convert.ToInt32(Console.ReadLine());

             // obtaining user desired operator  
            Console.WriteLine("Enter your desired operator (+, -, *, /): ");
            char ops = Console.ReadLine()[0];

            //storing the second operand for the operation
            Console.WriteLine("Enter the Second Oprand: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //handling each operator case made by the user
            switch(ops)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
                    break;
                case '/':
                    if (num2 == 0.0)
                        Console.WriteLine("Cannot divide by Zero!");
                    else
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
                    break;
                default:
                    Console.WriteLine("This operator, {0} is not compatible with this Calculator. \n " +
                        "Please Enter a Vaild Operator", ops );
                    break;



            }






        }

    }
}
