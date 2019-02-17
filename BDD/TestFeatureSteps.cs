using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit;
using NUnit.Framework;

namespace BDD
{
    [Binding]
    public class TestFeatureSteps
    {
        List<int> numbers = new List<int>();
        int result = 0;

        [Given(@"I have entered '(.*)' into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            numbers.Add(number);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            foreach (var number in numbers)
            {
                result += number;
            }
        }

        [Then(@"the result should be '(.*)' on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.True(expectedResult == result, "result is wrong.");
        }

    }
}
