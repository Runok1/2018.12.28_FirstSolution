using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsrtuctorTesting constructorTesting = new ConsrtuctorTesting();

            //ConsrtuctorTesting constructorTesting1 = new ConsrtuctorTesting(4, "first");
            //Console.WriteLine(constructorTesting1.GetPrivateInt());
            //Console.WriteLine(constructorTesting1.GetPrivateString());

            //ConsrtuctorTesting constructorTesting2 = new ConsrtuctorTesting(55, "second");
            //Console.WriteLine(constructorTesting2.GetPrivateInt());
            //Console.WriteLine(constructorTesting2.GetPrivateString());

            ConstructorChild constructorChild = new ConstructorChild(5);
            constructorChild.ShowProtectedInt();

            Console.ReadKey();
        }
    }
}
