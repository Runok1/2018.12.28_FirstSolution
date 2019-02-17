using System;

namespace FirstProject
{
    public class ExampleClass
    {
        public int parentInt = 7;
        private static bool parentBool = true;

        public static void TestMethod()
        {
            Console.WriteLine(parentBool);
            var parent = new ExampleClass();
            var test = parent.ReturnInt(4,3);
        }

        public string ReturnInt(int methodParameter1, int methodParameter2)
        {
            var result = methodParameter1 + methodParameter2;
            return result.ToString();
        }

        public void OverloadedMethod(int a1, string b1)
        {
            Console.WriteLine("Overloading 1");
        }

        public void OverloadedMethod(string b2, int a2)
        {
            Console.WriteLine("Overloading 2");
        }

        public int SumTwoInt(int a, int b)
        {
            var result = a + b;
            Console.WriteLine(result);
            return result;
        }
    }
}
