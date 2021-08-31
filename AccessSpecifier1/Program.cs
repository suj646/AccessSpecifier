using System;

namespace AccessSpecifier1
{


    class Student
    {
        public string UserName = "Sujit";

        public void print()
        {
            Console.WriteLine(" Student class");
        }
    }
    class Student2
    {
        public string UserName = "Pankaj";
        public void print()
        {
            Console.WriteLine(" Student 2 class");
        }
    }


    class Program : Student2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student student1 = new Student();
            Console.WriteLine("Name: " + student1.UserName);
            student1.print();
            Console.ReadLine();

            Program program = new Program();
            Console.WriteLine("Name: " + program.UserName);
            program.print();
            Console.ReadLine();

        }

    }
}