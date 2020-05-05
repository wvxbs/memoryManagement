using System;
using System.Collections;

namespace memoryManagement.src
{
    public class MemoryLeak
    {
        static ArrayList list = new ArrayList();
        public MemoryLeak()
        {
            Console.WriteLine("memoria memoria");
            list.Add(this);
        }
    }
}
