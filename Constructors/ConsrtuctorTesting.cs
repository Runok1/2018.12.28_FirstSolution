namespace Constructors
{
    public class ConsrtuctorTesting
    {
        public int privateInt = 5;
        public string privateString = string.Empty;

        public int GetPrivateInt()
        {
            return privateInt;
        }

        private string GetPrivateString()
        {
            return privateString;
        }

        public ConsrtuctorTesting(int privateInt, string privateString)
        {
            this.privateInt = privateInt;
            this.privateString = privateString;
            System.Console.WriteLine(GetPrivateString());
        }

        public ConsrtuctorTesting()
        {
        }
    }
}
