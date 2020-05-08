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
            /*if(i % 100000000 == 0) 
            {
             
            } */

            Console.WriteLine(i);
        }
    }
}