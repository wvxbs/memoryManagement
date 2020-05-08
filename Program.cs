using System;
using memoryManagement.ex1;
using memoryManagement.ex2;

namespace memoryManagement
{
    class Program
    {

        //static MemoryLeak m;
        //static MemoryLeakPatched mp;

        static void Main(string[] args)
        {
            int select = 0;

            while(true)
            {
                Console.WriteLine("Para Ex1: digite 1\nPara Ex2:Digite 2");

                if (int.TryParse(Console.ReadLine(), out select))
                {
                    //if (select.GetType() == typeof(int))
                    switch (select)
                    {
                        case 1:
                            runEx1();
                            break;
                        case 2:
                            runEx2();
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

        static void runEx1() 
        {
            MemoryLeak m = new MemoryLeak();
        }

        static void runEx2()
        {
            MemoryLeakPatched mp = new MemoryLeakPatched();
        }
    }
}