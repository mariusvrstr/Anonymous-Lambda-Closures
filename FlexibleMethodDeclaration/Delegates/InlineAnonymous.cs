using System;

namespace FlexibleMethodDeclaration.Delegates
{
    class InlineAnonymous
    {

        // Delegate variable
        private delegate int GetAgeDelegate(DateTime birthDay);
       
        private static void Main(string[] args) // Start method
        {
            var birthDay = new DateTime(1986, 04, 03); // Test Data

            // At runtime create an delegate method
            GetAgeDelegate getHumanYears = delegate(DateTime birthDayDate)
            { return ((DateTime.Today).Year - birthDayDate.Year); };

            // Invocation
            var age = getHumanYears(birthDay);

            Console.WriteLine("Human Age: " + age);
            Console.ReadLine();
        }

    }

}
