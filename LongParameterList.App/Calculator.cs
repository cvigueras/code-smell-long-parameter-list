using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LongParameterList.App
{
    public class Calculator
    {
        public int? Sum(int? number1 = null, int? number2 = null)
        {
            if(number1 == null || number2 == null)
            {
                return 0;
            }
            return number1.Value + number2.Value;
        }

        public int? Subtract(int? number1, int? number2)
        {
            if (number1 == null || number2 == null)
            {
                return 0;
            }
            return number1.Value - number2.Value;
        }

        public int? Multiply(int? number1, int? number2)
        {
            if (number1 == null || number2 == null)
            {
                return 0;
            }
            return number1.Value * number2.Value;
        }

        public int? Split(int? number1, int? number2)
        {
            if (number1 == null || number2 == null)
            {
                return 0;
            }
            return number1.Value / number2.Value;
        }
    }
}