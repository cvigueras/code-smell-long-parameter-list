namespace LongParameterList.App.Test
{
    internal class Calculator
    {
        public Calculator()
        {
        }

        public int DoOperation(int givenNUmber1, int givenNumber2, bool suma)
        {
            if (suma)
            {
                return givenNUmber1 + givenNumber2;
            }
            return givenNUmber1 - givenNumber2;
        }
    }
}