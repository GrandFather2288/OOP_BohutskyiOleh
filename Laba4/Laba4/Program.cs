using System;
using System.Collections.Generic;

namespace Laba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //Console.Write("Length: ");
            //float l = float.Parse(Console.ReadLine());
            //Console.Write("Width: ");
            //float w = float.Parse(Console.ReadLine());
            //Console.Write("Height: ");
            //float h = float.Parse(Console.ReadLine());

            //ClassBox box = new ClassBox(l, w, h);

            //Console.WriteLine();
            //Console.WriteLine("Surface Area – " + box.SurfaceArea());
            //Console.WriteLine("Lateral Surface Area – " + box.LateralSurfaceArea());
            //Console.WriteLine("Volume - " + box.Volume());
            #endregion

            #region Problem2
            // classbox constructor update
            #endregion

            #region Problem3
            //Console.Write("Name of the chicken: ");
            //string name = Console.ReadLine();
            //Console.Write("Age of the chicken: ");
            //int age = int.Parse(Console.ReadLine());

            //Chicken chicken = new Chicken(name, age);

            //Console.WriteLine("Chicken " + chicken.Name + " (age " + chicken.Age + " ) can produce " + chicken.ProductPerDay + " eggs per day.");
            #endregion

            #region Problem4
            //List<Person> persons = new List<Person>();
            //List<Product> products = new List<Product>();

            //Console.Write("How many Person`s will be: ");
            //int nPerson = int.Parse(Console.ReadLine());

            //string personName;
            //int money;

            //for(int i = 0; i < nPerson; i++)
            //{
            //    Console.Write(i + " Person name: ");
            //    personName = Console.ReadLine();

            //    Console.Write(i + " Person money: ");
            //    money = int.Parse(Console.ReadLine());

            //    Person person = new Person(personName, money);
            //    persons.Add(person);
            //}

            //Console.Write("How many products will be: ");
            //int nProduct = int.Parse(Console.ReadLine());

            //string productName;
            //int cost;

            //for (int i = 0; i < nProduct; i++)
            //{
            //    Console.Write(i + " Product name: ");
            //    productName = Console.ReadLine();

            //    Console.Write(i + " Product cost: ");
            //    cost = int.Parse(Console.ReadLine());

            //    Product product = new Product(productName, cost);
            //    products.Add(product);
            //}

            //Console.WriteLine();

            //string inputName = null;
            //string inputProduct = null;
            //string check = null;

            //while (check != "n")
            //{
            //    Console.Write("Who will be buy smth: ");
            //    inputName = Console.ReadLine();

            //    Console.Write("What " + inputName + " wants to buy: ");
            //    inputProduct = Console.ReadLine();

            //    Person.AddToBag(inputName, inputProduct, persons, products);

            //    Console.Write("Continue? y/n ");
            //    check = Console.ReadLine();
            //}

            //Console.WriteLine();

            //for(int i = 0; i < persons.Count; i++)
            //{
            //    Console.Write(persons[i].Name + " bought: ");
            //    for(int j = 0; j < persons[i].BagOfProducts.Count; j++)
            //    {
            //        Console.Write(persons[i].BagOfProducts[j] + ", ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Problem5
            //Console.Write("Pizza name: ");
            //string pizzaName = Console.ReadLine();

            //Console.Write("Dough type: ");
            //string doughType = Console.ReadLine();

            //Console.Write("Baking technique: ");
            //string bakingTechnique = Console.ReadLine();

            //Console.Write("Weight of dough: ");
            //float doughWeight = float.Parse(Console.ReadLine());

            //Dough dough = new Dough(doughType, bakingTechnique, doughWeight);

            //List<Topping> toppings = new List<Topping>();
            //string check = null;
            //while(check != "n")
            //{
            //    Console.Write("What topping you want to add: ");
            //    string toppingName = Console.ReadLine();

            //    Console.Write("Weight of this topping: ");
            //    float toppingWeight = float.Parse(Console.ReadLine());

            //    Topping topping = new Topping(toppingName, toppingWeight);
            //    toppings.Add(topping);

            //    Console.Write("Add more toppings? y/n ");
            //    check = Console.ReadLine();
            //}

            //Pizza pizza = new Pizza(pizzaName, dough, toppings);

            //Console.WriteLine();
            //Console.WriteLine(pizza.Name + " - " + pizza.TotalCalories + " Calories.");
            #endregion
        }
    }
}
