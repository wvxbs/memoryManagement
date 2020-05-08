using System;

namespace  memoryManagement.ex1
{
    public class Obj 
    {
        public Obj(long i )
        {
            runObj(i);
        }

        private void runObj(long i) 
        {
            Console.Write(i);
        }
    }
}