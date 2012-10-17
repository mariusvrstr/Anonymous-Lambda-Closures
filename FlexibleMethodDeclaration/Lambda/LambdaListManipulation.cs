using System;
using System.Collections.Generic;

namespace FlexibleMethodDeclaration.Lambda
{
    class LambdaListManipulation
    {
        private static void Main(string[] args) // Start method
        {

            var dataList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Get a sub list where numbers are even
            var evens = dataList.FindAll(y => y % 2 == 0);
            
            // Write all the even numbers out using lambda expression
            evens.ForEach(number => Console.Write(number + " "));
            Console.ReadLine();

        }
    }
}
