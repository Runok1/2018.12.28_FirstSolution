using System;

namespace Exceptions
{
    public class Program
    {
        public static void MethodWithException()
        {
            throw new Exception("My exception");
        }

        public static void Main(string[] args)
        {
            int a = 5;
            int b = 0;

            try
            {
                Console.WriteLine(a / b);
            }
            catch (ArithmeticException arithmeticException)
            {
                Console.WriteLine("I caught arithmetic exception");

                throw new Exception(arithmeticException.Message
                    + ". Plus my description");
            }
            catch (Exception exception)
            {
                Console.WriteLine("I caught exception");

                throw new Exception(exception.Message + ". Plus my description");
            }
            finally
            {
                Console.WriteLine("Finally area.");
            }

            Console.WriteLine("Ok");

            Console.ReadKey();
        }
    }
}
