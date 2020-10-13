using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Part_9_Classes
{
    
    class Student
    {
        private static Random generator = new Random();
        private string firstName;
        private string lastName;
        private int studentNum;
        private string email;
        public Student(string firstName, string lastName)
        {
            this.firstName = firstName.Trim();
            this.lastName = lastName.Trim();
            studentNum = generator.Next(999) + 555000;
            GenerateEmail();
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
                GenerateEmail();
            }
        }

         public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
                GenerateEmail();
            }
        }

        public int StudentNumber
        {
            get
            {
                return studentNum;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
        }


        public void ResetStudentNumber()
        {
            this.studentNum = generator.Next(999) + 555000;
            GenerateEmail();
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student; //cast obj to Student
            if (student == null) //protects us in case obj is null
                return false;

            return lastName;
            
        }

        private void GenerateEmail()
        {
            string firstThree, lastThree;

            if (firstName.Length <= 3)
            {
                firstThree = firstName;
            }
            else
            {
                firstThree = firstName.Substring(0, 3);
            }

            if (lastName.Length <= 3)
            {
                lastThree = lastName;
            }
            else
            {
                lastThree = lastName.Substring(0, 3);
            }

            
            email = firstThree + lastThree + (StudentNumber + "").Substring(3) + "@ICS4U.com";
           
            
        }
    }

    



}
