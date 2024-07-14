namespace LongParameterList.App.Test
{
    public class CalculatorShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DoSumSuccessfully()
        {
            var givenNUmber1 = 12;
            var givenNumber2 = 25;
            var calculator = new Calculator();

            var result = calculator.DoOperation(givenNUmber1,givenNumber2, true, false, false);

            Assert.IsTrue(result == givenNUmber1 + givenNumber2);
        }

        [Test]
        public void DoSubtractSuccessfully()
        {
            var givenNUmber1 = 25;
            var givenNumber2 = 20;
            var calculator = new Calculator();

            var result = calculator.DoOperation(givenNUmber1, givenNumber2, false, true, false);

            Assert.IsTrue(result == givenNUmber1 - givenNumber2);
        }

        [Test]
        public void DoMultiplySuccessfully()
        {
            var givenNUmber1 = 25;
            var givenNumber2 = 20;
            var calculator = new Calculator();

            var result = calculator.DoOperation(givenNUmber1, givenNumber2, false, false, true);

            Assert.IsTrue(result == givenNUmber1 * givenNumber2);
        }

        [Test]
        public void DoSplitSuccessfully()
        {
            var givenNUmber1 = 50;
            var givenNumber2 = 25;
            var calculator = new Calculator();

            var result = calculator.DoOperation(givenNUmber1, givenNumber2, false, false, false);

            Assert.IsTrue(result == givenNUmber1 / givenNumber2);
        }
    }
}