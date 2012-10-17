using System;

namespace FlexibleMethodDeclaration.Lambda
{
    class BasicApproachImplicit
    {
        private static void Main(string[] args) // Start method
        {

            var birthDayDate = new DateTime(1986, 04, 03); // Test Data

            // Create a basic implicit Lambda function - Syntax [Function = Parameter => Execution logic]
            Func<DateTime, int> getAgeFromDate = birthDay => ((DateTime.Today).Year - birthDay.Year);

            // Initiate the anonymous inline lambda expression
            var age = getAgeFromDate(birthDayDate);

            Console.WriteLine("Age: " + age);
            Console.ReadLine();

        }
    }
}
