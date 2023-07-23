using N01540305_Assignment4.AbstractFactory;
using N01540305_Assignment4.FactoryMethod;
using N01540305_Assignment4.Prototype;
using N01540305_Assignment4.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace N01540305_Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menuDriver = true;
            Console.WriteLine("Design Patterns (Creational Patterns) Assignment");
            while (menuDriver)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1 -> Demonstrate Singleton");
                Console.WriteLine("2 -> Demonstrate Prototype");
                Console.WriteLine("3 -> Demonstrate Factory method");
                Console.WriteLine("4 -> Demonstrate Abstract Factory method");
                Console.WriteLine("5 -> Exit");
                Console.WriteLine("-----------------------------------");

                switch (Console.ReadLine())
                {
                    case "1":
                        Course c1 = Course.GetCourse();
                        Course c2 = Course.GetCourse();
                        if (c1 == c2)
                        {
                            Console.WriteLine("Singleton works");
                        }
                        else
                        {
                            Console.WriteLine("Singleton failed");
                        }
                        break;
                    case "2":
                        Employee e1 = new Employee();
                        e1.ID = "e1";
                        e1.Name = "bob";
                        e1.Address = "62 Nottingham Ave";

                        Employee e2 = (Employee)e1.getClone();
                        e2.ID = "e2";

                        Console.WriteLine("student 1 : " + e1.ID + "-" + e1.Name + "-" + e1.Address);
                        Console.WriteLine("student 2 : " + e2.ID + "-" + e2.Name + "-" + e2.Address);

                        break;

                    case "3":
                        Recipe r1 = new CoffeeRecipe();
                        Recipe r2 = new IcecreamRecipe();

                        Console.WriteLine("Recipe 1 contains follwing ingredients : ");
                        foreach (Ingredient i in r1.GetIngredients())
                        {
                            Console.WriteLine(i.GetType().Name);
                        }

                        Console.WriteLine("Recipe 2 contains following ingredients : ");
                        foreach (Ingredient i in r2.GetIngredients())
                        {
                            Console.WriteLine(i.GetType().Name);
                        }


                        break;

                    case "4":
                        Client cl1 = new Client(new StoreA());
                        Client cl2 = new Client(new StoreB());
                        Console.WriteLine("client in conjunction with factory StoreA returned furniture : " + cl1.getFurniture().GetType().Name + " and bedding : " + cl1.getBedding().GetType().Name);
                        Console.WriteLine("client in conjunction with factory StoreB returned furniture : " + cl2.getFurniture().GetType().Name + " and bedding : " + cl2.getBedding().GetType().Name);
                        break;

                    case "5":
                        menuDriver = false;
                        break;
                }
            }
        }
    }
}
