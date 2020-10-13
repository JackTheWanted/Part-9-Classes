using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_9_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
 
            string firstName;
            string lastName;



            List<Student> students = new List<Student>();

            students.Add(new Student("Jack", "Carlson"));
            students.Add(new Student("Cole", "Cantwell"));
            students.Add(new Student("Tilso", "Beatie"));



            foreach (Student student in students)
            {
                Console.WriteLine(student);                
            }

            do
            {
                Console.WriteLine("Please enter the first name of a student you wish to add.");
                firstName = Console.ReadLine();

                Console.WriteLine("Please enter the last name of the student you wish to add.");
                lastName = Console.ReadLine();

                students.Add(new Student(firstName, lastName));

            } while (students.Count < 5);


            foreach (Student student in students)
            {
                Console.WriteLine(student.StudentNumber);

            }


            Console.ReadLine();
        }
    }
}
