using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class AmountDetails
    {
        int amount;
        string name;

        Shoping s = new Shoping();
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value;

                if (amount >= 10000)
                {
                    Console.Write("hello " + name);
                    s.doShoping();
                }
                else
                {
                    Console.Write("hello " + name);
                    s.canNotDoShoping();
                    Console.Write(" because you have only " + amount + " rupees but for doing shopping you should have atleast 10,000 ");
                    Console.WriteLine();
                }
            }
        }

    }

    internal class Shoping
    {


        public void doShoping()
        {
            Console.WriteLine(" you could do shoping");
        }
        public void canNotDoShoping()
        {
            Console.WriteLine(" you can not do shoping ,because you dont have enough money for shopping");
        }

    }


    internal class Program
    {

        static void Main(string[] args)
        {
            AmountDetails obj = new AmountDetails();
            Console.WriteLine("please enter you name");
            obj.Name = Console.ReadLine();

            Console.WriteLine("please enter your amount");
            obj.Amount = Convert.ToInt16(Console.ReadLine());


        }
    }
}
