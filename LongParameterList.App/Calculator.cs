using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LongParameterList.App
{
    public class Calculator
    {
        public int? Sum(int? number1, int? number2)
        {
            return number1.Value + number2.Value;
        }

        public int? Subtract(int? number1, int? number2)
        {
            return number1.Value - number2.Value;
        }

        public int? Multiply(int? number1, int? number2)
        {
            return number1.Value * number2.Value;
        }

        public int? Split(int? number1, int? number2)
        {
            return number1.Value / number2.Value;
        }

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