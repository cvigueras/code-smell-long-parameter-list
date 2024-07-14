namespace LongParameterList.App
{
    public class Calculator
    {
        public int? DoOperation(bool suma, bool resta, bool multiplica, int? givenNUmber1 = null, int? givenNumber2 = null)
        {
            if(givenNUmber1 == null || givenNumber2 == null)
            {
                return 0;
            }
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