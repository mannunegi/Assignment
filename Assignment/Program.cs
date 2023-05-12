using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionProject
{

    class First
    {
     ArrayList list= new ArrayList();

        public void AddData()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("enter the value : ");
                string name = Console.ReadLine();
                list.Add(name);
                Console.WriteLine("do you want to continue. type y for yes");
                char ch = Convert.ToChar(Console.ReadLine());
                if (!(ch == 'Y' && ch == 'y'))
                {
                    flag = false;
                }
            }
        }
        public void RemoveData() {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("enter the value you want to remove :");
                string name = Console.ReadLine();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == name)
                    {
                        list.RemoveAt(i);
                        Console.WriteLine("value is removed");
                    }
                }
                Console.WriteLine("do you want to continue :");
                char ch = Convert.ToChar(Console.ReadLine());
                if (!(ch == 'Y' && ch == 'y'))
                {
                    flag = false;
                }
            }
        }

        public  void Search()
        {
            Console.WriteLine("enter the value ,you want to search : ");
            string name=Console.ReadLine();
            for(int i=0; i < list.Count;i++)
            {
                if (list[i]==name) {

                    Console.WriteLine("the name is present in the list");
                
                }
            }
        }

        public void update
    
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            First f= new First();
            Console.WriteLine("enter your choice : ");
            int choice=Convert.ToInt16(Console.ReadLine()); 

            switch(choice)
            {
                case 1:
                    f.AddData(); break;

                case 2:
                    f.RemoveData(); break;


                case 3:
                    f.Search(); break;


            }
            
        }
    }
}
