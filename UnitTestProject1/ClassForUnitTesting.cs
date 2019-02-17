using System;

namespace UnitTestProject
{
    public class ClassForUnitTesting
    {

        public void TestOut(out int number)
        {
            number = 54;           
        }

        public int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private void VerifyValidData(int number)
        {
            if (number < -1000 || number > 1000)
            {
                throw new Exception($"Input parameter should be from"
                    + $" -1000 to 1000. Actual values is {number}");
            }
        }

        public int DivideTwoInt(int firstNumber, int secondNumber)
        {
            VerifyValidData(firstNumber);
            VerifyValidData(secondNumber);
            return firstNumber / secondNumber;
        }
    }
}
