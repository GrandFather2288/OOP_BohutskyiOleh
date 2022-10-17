using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class Person
    {

        #region Fields

        string name;
        int age;

        #endregion

        #region Constructors

        public Person() 
        {
            name = "No name";
            age = 1;
        }

        public Person(int age)
        {
            name = "No name";
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        #endregion 

        #region Properties

        public string Name { get; set; }

        public int Age { get; set; }

        #endregion

        #region Methods

        public static void OpinionPoll()
        {
            Console.Write("How many persons you want to add: ");
            int n = int.Parse(Console.ReadLine());

            List<Person> list = new List<Person>();

            string pName;
            int pAge;

            for(int i = 0; i < n; i++)
            {
                Console.Write("Input name of the " + (i + 1) + " person: ");
                pName = Console.ReadLine();

                Console.Write("Input age of the " + (i + 1) + " person: ");
                pAge = int.Parse(Console.ReadLine());

                Person person = new Person();

                person.Name = pName;
                person.Age = pAge;

                list.Add(person);
                Console.WriteLine();
            }

            Console.WriteLine("Age >= 30: ");
            for(int i = 0; i < n; i++)
            {
                if (list[i].Age >= 30)
                {
                        Console.WriteLine();
                        Console.Write(list[i].Name + " ");
                        Console.Write(list[i].Age);
                        Console.WriteLine();
                }
            }
        }

        #endregion

    }
}
