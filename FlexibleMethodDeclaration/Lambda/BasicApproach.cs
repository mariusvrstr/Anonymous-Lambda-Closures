using System;


namespace FlexibleMethodDeclaration.Lambda
{
    class BasicApproach
    {
        private static void Main(string[] args) // Start method
        {

            var num = 5;

            // Lambda Syntax [Action/Func = Parameter => Execution logic]
            Action paramLess = () => Console.WriteLine("Sandra");

            // Lambda with parameter
            Func<int, int> funcIncrement = a => a + 1;

            paramLess.Invoke();    // Invoke action
            Console.WriteLine(funcIncrement.Invoke(num)); // Invoke function

            Console.ReadLine();

        }

    }
}
