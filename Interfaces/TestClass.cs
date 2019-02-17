using System;

namespace Interfaces
{
    public class TestClass : ParentClass, IFirstInterface, ISecondInterface 
    {
        public int SomeMethod1(int a)
        {
            Console.WriteLine("Some implementation 1");
            return 0;
        }

        public void SomeMethod2()
        {
            Console.WriteLine("Some implementation 2");
        }
    }
}
