namespace Constructors
{
    public class ConstructorParent
    {
        protected int protectedInt;
        protected string protectedStr;

        public ConstructorParent()
        {
            System.Console.WriteLine("Constructor Parent");

        }

        //public ConstructorParent(int a)
        //{
        //    System.Console.WriteLine("Constructor Parent");
        //    protectedInt = a;
        //}

        //public ConstructorParent(string a)
        //{
        //    System.Console.WriteLine("Constructor Parent");
        //    protectedStr = a;
        //}

        public void ShowProtectedInt()
        {
            System.Console.WriteLine(protectedInt);
        }
    }
}
