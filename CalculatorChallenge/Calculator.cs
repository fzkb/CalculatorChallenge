using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorChallenge
{
    public class Calculator
    {
        private string _numberList;
        private int[] _numbers;

        public Calculator(string values)
        {
            _numberList = values;
        }

        public string validateNumber()
        {
            string isValid = "valid";

            int tempValue = 0;


            if (_numberList.Length > 0)
            {
                if (_numberList.IndexOf(",") >= 0)
                {
                    string[] strNumbers = _numberList.Split(",".ToCharArray());

                    if (strNumbers.Length <= 2)
                    {
                        _numbers = new int[strNumbers.Length];

                        int counter = 0;

                        foreach (var valu in strNumbers)
                        {
                            int.TryParse(valu, out tempValue);

                            _numbers[counter] = tempValue;

                            counter++;
                        }
                    }
                    else
                    {
                        isValid = "You entered more than 2 numbers. Please enter only two numbers (,) seprated.";
                    }
                }
                else if (_numberList.Length > 0)
                {
                    _numbers = new int[1];

                    int.TryParse(_numberList, out tempValue);

                    _numbers[0] = tempValue;
                }
                else
                {
                    isValid = "Number list is empty";
                }

            }


            return isValid;
        }
        public int addNumber()
        {
            var result = 0;
            if (_numbers.Length > 0)
            {
                for (int i = 0; i < _numbers.Length; i++)
                {
                    result += _numbers[i];
                }
            }

            return result;
        }

        public double subtractNumber(int[] numbers)
        {
            return 0.0;
        }

        public double multiplyNumber(int[] numbers)
        {
            return 0.0;
        }

        public double divideNumber(int[] numbers)
        {
            return 0.0;
        }
    }
}
