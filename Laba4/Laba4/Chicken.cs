using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Chicken
    {
        #region Fields
        string name;
        int age;
        #endregion

        #region Constructor
        public Chicken(string name, int age)
        {
            if(name == null || name == " " || name == string.Empty)
            {
                Console.WriteLine("Name can`t be empty!");
            }
            else
            {
                this.name = name;
            }

            if(age <= 0 || age > 15)
            {
                Console.WriteLine("Age should be between 0 and 15");
            }
            else
            {
                this.age = age;
            }
        }
        #endregion

        #region Properties
        public string Name 
        { 
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public int ProductPerDay
        {
            get { return CalculateProductPerDay(); }
        }
        #endregion

        #region Methods
        int CalculateProductPerDay()
        {
            int res = 0;

            if(age > 0 && age <= 2)
            {
                res = 0;
            }

            if(age > 2 && age <= 10)
            {
                res = 1;
            }

            if(age > 10 && age <= 15)
            {
                res = 2;
            }

            return res;
        }
        #endregion
    }
}
