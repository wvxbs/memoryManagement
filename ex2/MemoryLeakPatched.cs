using System;
using System.Collections;
using memoryManagement.ex1;

namespace memoryManagement.ex2
{
    public class MemoryLeakPatched
    {
        ArrayList list = new ArrayList();

        public MemoryLeakPatched()
        {
            runMemoryLeakPatch();
        }

        public void runMemoryLeakPatch()
        {
            long i = 0;
            long limit = 100000;
            Obj o = new Obj(i);
            
            try 
            {
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
