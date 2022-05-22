using API.Calc.Interfaces;

namespace API.Calc.Mgr
{
    public class CalculateMgr : ICalculate
    {
        public int Add(int? value1, int? value2)
        {
            int[] inputs = validateInput(value1, value2);
            return inputs[0] + inputs[1];
        }

        public int Divide(int? value1, int? value2)
        {
            
            int[] inputs = validateInput(value1, value2);

            //As you cannot divide by 0 i am checking for this and either returning the whole number or 0
            if (inputs[0] == 0 && inputs[1] ==0)
            {
                return 0;
            }
            else if(inputs[1] == 0)
            {
                return inputs[0];
            }

            return inputs[0] / inputs[1];
        }

        public int Multiply(int? value1, int? value2)
        {
            int[] inputs = validateInput(value1, value2);
            return inputs[0] * inputs[1];
        }

        public int Subtract(int? value1, int? value2)
        {
            int[] inputs = validateInput(value1, value2);
            return inputs[0] - inputs[1];
        }

        private int[] validateInput(int? value1, int? value2)
        {
            int[] numbers = { value1.GetValueOrDefault(0), value2.GetValueOrDefault(0) };

            return numbers;
        }
    }
}
