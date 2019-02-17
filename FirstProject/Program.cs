using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExampleClass parent1 = new ExampleClass();
            //Console.WriteLine(parent1.parentInt);
            //parent1.parentInt = 100;
            //Console.WriteLine(parent1.parentInt);

            //ExampleClass parent2 = new ExampleClass();
            //Console.WriteLine(parent2.parentInt);

            //Parent.parentInt = 100;
            //Console.WriteLine(Parent.parentInt);
            //Console.WriteLine(Parent.parentBool);
            //ExampleClass.TestMethod();

            //var returnedInt = parent1.ReturnInt(5, 8);

            //Console.WriteLine(returnedInt);

            //Child child = new Child();
            //child.ParentMethod();
            //child.ChildMethod();

            //child.MethodForOverriding();

            Properties properties = new Properties();
            properties.MyProperty = 10000;

            Console.WriteLine(properties.MyProperty);

            Console.ReadKey();
        }
    }
}
