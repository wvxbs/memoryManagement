using System;
using System.Collections;

namespace memoryManagement.ex1.src
{
    public class MemoryLeak
    {
        static ArrayList list = new ArrayList();

        public MemoryLeak()
        {
            this.runMemoryLeak();
        }

        public void runMemoryLeak()
        {
            long i = 0;
            long limit = 100000000000000;

            Obj o = new Obj(i,limit);

            while(i < limit)
            { 
                list.Add(o);
                i++;
            }
        }
    }
}
