using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexibleMethodDeclaration
{
    class LambdaStringFind
    {
        private static void Main(string[] args) // Start method
        {
            var fullName = new List<string> { "Rolf Sigh", "peter haring", "tanya labert",
                "elsie smith", "jane seemore", "greg smith" };

            var theFirstSmith = fullName.Find(y => y.ToLower().Contains("smith"));

            Console.Write(theFirstSmith);
            Console.ReadLine();
        }
    }
}
