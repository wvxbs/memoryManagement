using System;

namespace  memoryManagement.src
{
    public class Obj 
    {
        public Obj(long i, long limit)
        {
            runObj(i, limit);
        }

        private void runObj(long i, long limit) 
        {
            long count = i + (i * limit);
            Console.Write(count.ToString());
        }
    }
}