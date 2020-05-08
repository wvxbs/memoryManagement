using System;
using memoryManagement.ex1;
using memoryManagement.ex2;

namespace memoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            int select = 0;

            while(true)
            {
                Console.WriteLine("Para Ex1: digite 1\nPara Ex2:Digite 2");
                select = int.Parse(Console.ReadLine());

                if(select.GetType() == typeof(int)) 
                {
                    switch(select)
                    {
                        case 1:
                            MemoryLeak m = new MemoryLeak();
                        break;
                        case 2:
                            MemoryLeakPatched mp = new MemoryLeakPatched();   
                        break;
                        default:
                            Console.WriteLine("\nerro");
                        break;
                    }
                } 
                else
                {
                    Console.WriteLine("erro");
                }
            }
        }
    }
}