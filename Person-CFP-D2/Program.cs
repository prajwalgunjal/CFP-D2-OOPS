using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_CFP_D2
{
    public class Teacher : Person_CFP_D2
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }

    class StudentAndTeacherTest
    {
        static void Main()
        {
            //Create a Person and make it say hello
            Person_CFP_D2 myPerson = new Person_CFP_D2();
            myPerson.Greet();

            /*Create a student, set his age to 21, 
              tell him to Greet and display his age*/
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            /*Create a teacher, 30 years old, 
             *ask him to say hello and then explain*/
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();
        }
    }

    class Student : Person_CFP_D2
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
    }

    public class Person_CFP_D2
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }

}