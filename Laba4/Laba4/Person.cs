using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Person
    {
        #region Fields
        string name;
        int money;
        List<string> bagOfProducts = new List<string>();
        #endregion

        #region Constructor
        public Person(string name, int money)
        {
            if (name == null || name == string.Empty || name == " ")
            {
                Console.WriteLine("Name can`t be empty.");
            }
            else
            {
                this.name = name;
            }

            if (money < 0)
            {
                Console.WriteLine("Money can`t be negative.");
            }
            else
            {
                this.money = money;
            }
        }
        #endregion

        #region Properties
        public string Name 
        { 
            get { return name; } 
        }

        public List<string> BagOfProducts
        {
            get { return bagOfProducts; }
            set { bagOfProducts = value; }
        }
        #endregion

        #region Methods
        public static void AddToBag(string name, string product, List<Person> persons, List<Product> products)
        {
            for(int i = 0; i < persons.Count; i++)
            {
                if(persons[i].Name == name)
                {
                    for(int j = 0; j < products.Count; j++)
                    {
                        if(products[j].Name == product)
                        {
                            if(persons[i].money >= products[j].Cost)
                            {
                                persons[i].bagOfProducts.Add(products[j].Name);
                                persons[i].money -= products[j].Cost;
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
