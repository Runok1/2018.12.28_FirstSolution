using System;

namespace FirstProject
{
    public class Child : Parent
    {
        /// <summary>
        /// Test explanation
        /// </summary>
        public void ChildMethod()
        {
            Console.WriteLine("Child method");
        }

        public override void MethodForOverriding()
        {
            Console.WriteLine("Child method for overriding");
        }
    }
}
