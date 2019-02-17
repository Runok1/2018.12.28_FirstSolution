namespace HW
{
    public class Animal
    {
        protected string sound = "Gav";

        public virtual void MakeSound()
        {
            System.Console.WriteLine(sound);
        }
    }
}
