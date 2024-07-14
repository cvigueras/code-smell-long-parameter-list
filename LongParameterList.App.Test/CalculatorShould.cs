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

            var result = calculator.DoOperation(givenNUmber1,givenNumber2);

            Assert.IsTrue(result == givenNUmber1 + givenNumber2);
        }
    }
}