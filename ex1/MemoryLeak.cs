using System;
using System.Collections;

namespace memoryManagement.ex1
{
    public class MemoryLeak
    {
        static ArrayList list = new ArrayList();

        public MemoryLeak()
        {
            runMemoryLeak();
        }

        public void runMemoryLeak()
        {
            long i = 0;
            long limit = 100000;
            Obj o = new Obj(i);
            
            try{
                while(i < limit)
                {
                    list.Add(o);
                    i++;
                    
                }
            }

            catch(Exception e) 
            {
                Console.WriteLine($"exception: {e.Message} Index: {i}");
            }

            Console.WriteLine("\nConcluído");
        }
    }
}
