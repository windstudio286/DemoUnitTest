using System;
using DemoUnitTest.Services;
using TechTalk.SpecFlow;

namespace DemoUnitTest.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _result;
        private Calculator _calculator;

        public CalculatorSteps()
        {
            _calculator = new Calculator();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            if (_firstNumber == 0)
            {
                _firstNumber = number;
            }
            else
            {
                _secondNumber = number;
            }
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add(_firstNumber, _secondNumber);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _result);
        }
    }
}

