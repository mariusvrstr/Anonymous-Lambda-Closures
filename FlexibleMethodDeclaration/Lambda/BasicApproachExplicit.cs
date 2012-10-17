using System;

namespace FlexibleMethodDeclaration.Lambda
{
    class BasicApproachExplicit
    {
        private static void Main(string[] args) // Start method
        {

            var birthDayDate = new DateTime(1986, 04, 03); // Test Data
            
            // Create a basic explicit Lambda function with statement body
            Func<DateTime, int> getAgeFromDate = (DateTime birthDay) =>
                                                     { return ((DateTime.Today).Year - birthDay.Year); }; 

            // Initiate the anonymous inline lambda expression
            var age = getAgeFromDate(birthDayDate);

            Console.WriteLine("Age: " + age);
            Console.ReadLine();

        }
    }
}
