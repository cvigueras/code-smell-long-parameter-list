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

            var result = calculator.Sum(givenNUmber1, givenNumber2);

            Assert.IsTrue(result == givenNUmber1 + givenNumber2);
        }

        [Test]
        public void DoSubtractSuccessfully()
        {
            var givenNUmber1 = 25;
            var givenNumber2 = 20;
            var calculator = new Calculator();

            var result = calculator.Subtract(givenNUmber1, givenNumber2);

            Assert.IsTrue(result == givenNUmber1 - givenNumber2);
        }

        [Test]
        public void DoMultiplySuccessfully()
        {
            var givenNUmber1 = 25;
            var givenNumber2 = 20;
            var calculator = new Calculator();

            var result = calculator.Multiply(givenNUmber1, givenNumber2);

            Assert.IsTrue(result == givenNUmber1 * givenNumber2);
        }

        [Test]
        public void DoSplitSuccessfully()
        {
            var givenNUmber1 = 50;
            var givenNumber2 = 25;
            var calculator = new Calculator();

            var result = calculator.DoOperation(false, false, false, givenNUmber1, givenNumber2);

            Assert.IsTrue(result == givenNUmber1 / givenNumber2);
        }

        [Test]
        public void GetZeroWhenFirstNumberParameterIsNull()
        {
            var givenNumber2 = 25;
            var calculator = new Calculator();

            var result = calculator.DoOperation(false, false, false, null, givenNumber2);

            Assert.IsTrue(result == 0);
        }

        [Test]
        public void GetZeroWhenSecondNumberParameterIsNull()
        {
            var givenNumber2 = 25;
            var calculator = new Calculator();

            var result = calculator.DoOperation(false, false, false, givenNumber2);

            Assert.IsTrue(result == 0);
        }

        [Test]
        public void GetZeroWhenBothNumbersParameterAreNull()
        {
            var calculator = new Calculator();

            var result = calculator.DoOperation(false, false, false);

            Assert.IsTrue(result == 0);
        }
    }
}