using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal class Employee
    {
        #region Fields

        //mentadory
        string name;
        float salary;
        string position;
        string department;

        //optional
        string email;
        int age;

        #endregion

        #region Constructors

        public Employee(string name, float salary, string position, string department, string email, int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;

            if (email != null)
            {
                this.email = email;
            }
            else
            {
                this.email = "n/a";
            }

            if (age != null)
            {
                this.age = age;
            }
            else
            {
                this.age = -1;
            }
        }

        #endregion

        #region Properties

        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        #endregion

        #region Methods

        public static void CompanyRoster()
        {
            //mentadory
            string name;
            float salary;
            string position;
            string department;

            //optional
            string email;
            int age;

            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees you want to add: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = float.Parse(Console.ReadLine());
                Console.Write("Position: ");
                position = Console.ReadLine();
                Console.Write("Department: ");
                department = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Age: ");
                age = int.Parse(Console.ReadLine());

                Employee employee = new Employee(name, salary, position, department, email, age);
                employees.Add(employee);
            }


            Console.Write("Highest Average Salary: " + HighestSalaryDepartment(employees));


        }

        static string HighestSalaryDepartment(List<Employee> a)
        {
            float n = 0;
            float sum = 0;
            float average = 0;
            float maxAverage = 0;
            string res = null;

            for (int i = 0; i < a.Count - 1; i++)
            {
                n = 1;
                sum = a[i].Salary;
                for(int j = i+1; j < a.Count - 1; j++)
                {
                    if(a[i].Department == a[j].Department)
                    {
                        n++;
                        sum += a[j].Salary;
                        average = sum / n;

                        if (average > maxAverage)
                        {
                            maxAverage = average;
                            res = a[i].Department;
                        }
                    }
                }
            }

            return res;
        }
            #endregion
        }
}
