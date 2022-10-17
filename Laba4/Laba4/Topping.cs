using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Topping
    {
        #region Fields
        string type;
        float weight;
        #endregion

        #region Constructor
        public Topping(string type, float weight)
        {
            if (type == "meat" || type == "veggies" || type == "cheese" || type == "sauce")
            {
                this.type = type;
            }
            else
            {
                Console.WriteLine("Invalid type of topping");
            }

            if (weight > 0 && weight <= 50)
            {
                this.weight = weight;
            }
            else
            {
                Console.WriteLine("Topping weight should be in the range [1..50].");
            }
        }
        #endregion

        #region Properties
        public string Type
        {
            get { return type; }
            set
            {
                if(value == "meat" || value == "veggies" || value == "cheese" || value == "sauce")
                {
                    type = value;
                }
                else
                {
                    Console.WriteLine("Invalid type of topping");
                }
            }
        }

        public float Weight
        {
            get { return weight; }
            set
            {
                if(value > 0 && value <= 50)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("Topping weight should be in the range [1..50].");
                }
            }
        }

        public float TotalCalories
        {
            get { return ToppingCalories(); }
        }
        #endregion

        #region Methods
        float ToppingCalories()
        {
            float typeCoef = 0;

            if(type == "meat")
            {
                typeCoef = 1.2f;
            }
            else if(type == "veggies")
            {
                typeCoef = 0.8f;
            }
            else if(type == "cheese")
            {
                typeCoef = 1.1f;
            }
            else if(type == "sauce")
            {
                typeCoef = 0.9f;
            }

            return weight * typeCoef;
        }
        #endregion
    }
}
