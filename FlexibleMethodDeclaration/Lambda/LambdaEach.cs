using System;
using System.Collections.Generic;

namespace FlexibleMethodDeclaration.Lambda
{
    internal class LambdaEach
    {
        private static void Main(string[] args) // Start method
        {

            // Example numeric data list
            var dataList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var total = 0;
            
            // Iterate through list with lambda expression
            dataList.ForEach(number => total += number);

            Console.WriteLine("Total: " + total);
            Console.ReadLine();

        }
    }
}