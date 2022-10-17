using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Pizza
    {
        #region Fields
        string name;
        Dough dough = null;
        List<Topping> toppings = new List<Topping>();
        int numberOfToppings;
        #endregion

        #region Constructor
        public Pizza(string name, Dough dough, List<Topping> toppings)
        {
            this.name = name;
            this.dough = dough;
            this.toppings = toppings;
            if (toppings.Count > 0 && toppings.Count <= 10)
            {
                numberOfToppings = toppings.Count;
            }
            else
            {
                Console.WriteLine("Number of toppings should be in range [0..10].");
            }
        }
        #endregion

        #region Properties
        public string Name 
        { 
            get { return name; }
        }

        public float TotalCalories
        {
            get { return PizzaCalories(); }
        }
        #endregion

        #region Methods
        float ToppingsCalories()
        {
            float res = 0;

            for (int i = 0; i < toppings.Count; i++)
            {
                res += toppings[i].TotalCalories;
            }

            return res;
        }
        float PizzaCalories()
        {
            return dough.TotalCalories + ToppingsCalories();
        }
        #endregion
    }
}
