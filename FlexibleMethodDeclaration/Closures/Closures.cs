using System;
using System.Collections.Generic;
using System.Linq;

namespace FlexibleMethodDeclaration.Closures
{

    public class MathClass // Parent Object
     {
        public decimal Average { get; set; }
        public List<Student> StudentList { get; set; }

        // Named method - The location from where it should execute
        public void Recalcalculate() 
        {
            double total = 0;
            StudentList.ForEach(student => total += student.Grade);
            Average = Math.Round((decimal)(total/StudentList.Count()), 2);
        }

        public void AddStudent(Student student)
        {
            if (StudentList == null) {StudentList = new List<Student>(); }

            // Map each child delegate to parent named method
            student.Refresh = Recalcalculate;

            StudentList.Add(student); // Add to list
        }
     }


    public class Student // Child Object
    {
        // Delegate variable
        public delegate void DelegateContainer();
        // Delegate placeholder, to be pointed to parent named method
        public DelegateContainer Refresh;

        private int _grade;
        public int Grade
        {
            get { return _grade; }
            set
            {
                _grade = value; 
                Refresh(); // This triggers the Refresh delegate
            } 
        }
        public string Name { get; set; }

        public Student(string name, int grade)
        {
            _grade = grade;
            Name = name;
        }
    }

    
    class Closures
    {

        private static MathClass PopulateTestData()
        {
            var mathClass = new MathClass();

            mathClass.AddStudent(new Student("Jane", 48));
            mathClass.AddStudent(new Student("John", 45));

            // After adding children execute the re-calculate
            mathClass.Recalcalculate();

            return mathClass;
        }


        private static void Main(string[] args) // Start method
        {
            var mathClass = PopulateTestData(); // Test Data

            Console.WriteLine("Average Before: " + mathClass.Average);

            // Update a child that will execute from within the parent context
            mathClass.StudentList[0].Grade = 98;
            Console.WriteLine("Average After: " + mathClass.Average); // Affects parent

            Console.ReadLine();
        }
    }
}
