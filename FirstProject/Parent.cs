using System;

namespace FirstProject
{
    public class Parent
    {
        public int parentInt = 7;

        public void ParentMethod(int a = 4, int b = 6)
        {
            if (a < b)
            {
                return;
            }           
            Console.WriteLine($"Parent method {a}");
        }

        public virtual void MethodForOverriding()
        {
            Console.WriteLine("Parent method for overriding");
        }
    }
}
