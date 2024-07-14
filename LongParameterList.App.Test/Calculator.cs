namespace LongParameterList.App.Test
{
    internal class Calculator
    {
        public Calculator()
        {
        }

        public int DoOperation(int givenNUmber1, int givenNumber2, bool suma, bool resta, bool multiplica)
        {
            if (suma)
            {
                return givenNUmber1 + givenNumber2;
            }
            if (resta)
            {
                return givenNUmber1 - givenNumber2;
            }
            if (multiplica)
            {
                return givenNUmber1 * givenNumber2;
            }
            return givenNUmber1 / givenNumber2;
        }
    }
}