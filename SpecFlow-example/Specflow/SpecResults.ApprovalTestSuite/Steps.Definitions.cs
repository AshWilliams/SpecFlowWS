using System;
using NUnit.Framework;
using SpecResults.Json;
using TechTalk.SpecFlow;
using CalculatorLibrary;
namespace SpecResults.ApprovalTestSuite
{
	[Binding]
	public partial class Steps : ReportingStepDefinitions
	{
		[BeforeTestRun]
		public static void BeforeTestRun()
		{
			Reporters.FixedRunTime = DateTime.MinValue;
			Reporters.Add(new JsonReporter());
			IntializeApprovalTests();
		}
        Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }
        int result=0;
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(result,expectedResult,"Wrong Result");
        }
    }

}