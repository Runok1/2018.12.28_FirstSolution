namespace FirstProject
{
    public class Properties
    {
        private int privateInt; 

        public int MyProperty
        {
            get { return privateInt / 100; }

            set { privateInt = value; }
        }

        public int MyProperty1 { get; set; }
    }
}
