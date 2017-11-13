using System;

namespace AdapterPattern.StructuralCode
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}