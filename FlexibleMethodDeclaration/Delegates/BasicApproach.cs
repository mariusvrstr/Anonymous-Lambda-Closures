using System;

namespace FlexibleMethodDeclaration.Delegates
{
    class BasicApproach
    {

        delegate int GetAgeDelegate(DateTime birthDay); // Delegate variable

        // Normal named method
        public static int CalculateDogYears(DateTime birthDay)
        { return ((DateTime.Today).Year - birthDay.Year) * 7; }

        static void Main(string[] args) // Start method
        {
            var birthDay = new DateTime(1986, 04, 03); // Test Data

            // Assigned the named method to delegate placeholder
            GetAgeDelegate getDogYears = CalculateDogYears;

            var age = getDogYears(birthDay); // Execute

            Console.WriteLine("Dog Age: " + age);
            Console.ReadLine();
        }

    }
}
