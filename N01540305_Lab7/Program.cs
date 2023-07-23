using N01540305_Lab7.AbsractFactory;
using N01540305_Lab7.FactoryMethod;
using N01540305_Lab7.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menuDriver = true;
            while (menuDriver) {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1 -> Demonstrate Prototype");
                Console.WriteLine("2 -> Demonstrate Factory method");
                Console.WriteLine("3 -> Demonstrate Abstract Factory method");
                Console.WriteLine("4 -> Exit");
                Console.WriteLine("-----------------------------------");

                switch (Console.ReadLine())
                {
                    case "1":
                        Student s1 = new Student();
                        s1.Name = "Bob";
                        s1.description = "examples";

                        Student s2 = (Student) s1.getClone();
                        s2.Name = "Peter";

                        Console.WriteLine("Student 1 : " + s1.Name + "-" + s1.description);
                        Console.WriteLine("Student 2 : " + s2.Name + "-" + s2.description);

                        break;

                    case "2":
                        Document d1 = new EBook();
                        Document d2 = new SalesReport();

                        Console.WriteLine("Document 1 contains : ");
                        foreach (Page p in d1.getPages())
                        {
                            Console.WriteLine(p.GetType().Name);
                        }

                        Console.WriteLine("Document 2 contains : ");
                        foreach (Page p in d2.getPages())
                        {
                            Console.WriteLine(p.GetType().Name);
                        }


                        break;
                    
                    case "3":
                        Client c1 = new Client(new VehicleFactoryA());
                        c1.Compare();
                        Client c2 = new Client(new VehicleFactoryB());
                        c2.Compare();
                        break;

                    case "4":
                        menuDriver = false;
                        break;
                }
            }
        }
    }
}
