using System;
using System.Collections;
using memoryManagement.ex1;

namespace memoryManagement.ex2
{
    public class MemoryLeakPatched
    {
        static ArrayList list = new ArrayList();

        public MemoryLeakPatched()
        {
            this.runMemoryLeak();
        }

        public void runMemoryLeak()
        {
            long i = 0;
            long limit = 1000000000000000000;

            while(i < limit)
            {
                Obj o = new Obj(i);
                list.Add(o);
                i++;
            }

            Console.WriteLine("\nConcluído");
        }
    }
}
