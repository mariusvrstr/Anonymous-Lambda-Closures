using System;

namespace FlexibleMethodDeclaration.Delegates
{
    class GenericAnonymous
    {

        static void Main(string[] args) // Start method
        {

            var birthDayDate = new DateTime(1986, 04, 03); // Test Data

            // Create anonymous generic function
            Func<DateTime, int> getDogYearsFromDate = delegate(DateTime birthDay)
            { return ((DateTime.Today).Year - birthDay.Year) * 7; };

            var dogAge = getDogYearsFromDate(birthDayDate);

            Console.WriteLine("Dog Age: " + dogAge);
            Console.ReadLine();
        }
        
    }
}
