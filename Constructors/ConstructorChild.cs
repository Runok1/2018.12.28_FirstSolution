namespace Constructors
{
    public class ConstructorChild : ConstructorParent
    {
        //public ConstructorChild()
        //{
        //    System.Console.WriteLine("Constructor Child");
        //}

        public ConstructorChild(int a)// : base(5757)
        {
            System.Console.WriteLine("Constructor Child with parameter");
            protectedInt = a;
        }

    }
}
