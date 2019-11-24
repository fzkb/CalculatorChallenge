using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CalculatorChallenge
{
    public class Calculator
    {
        private string _numberList;
        private int[] _numbers;
        private List<int> _negativeNumbers = new List<int>();

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

                string splitOn = @"[//,\\n,,,#,*]";

                string[] strNumbers = Regex.Split(_numberList, splitOn);

                if (strNumbers.Length > 0)
                {
                    _numbers = new int[strNumbers.Length];

                    int counter = 0;

                    foreach (var valu in strNumbers)
                    {
                        int.TryParse(valu, out tempValue);

                        if (tempValue > 0 && tempValue < 1000)
                        {
                            _numbers[counter] = tempValue;
                        }

                        if (tempValue > 1000)
                        {
                            _numbers[counter] = 0;
                        }

                        if (tempValue < 0)
                        {
                            _negativeNumbers.Add(tempValue);
                            _numbers[counter] = tempValue;
                        }

                        counter++;
                    }

                }                
                else
                {
                    isValid = "Number list is empty";
                }

            }

            if (_negativeNumbers.Count > 0)
                isValid = "Please provide +ve integer values";


            return isValid;
        }
        public int addNumber()
        {
            var result = 0;
            if (_numbers != null && _numbers.Length > 0)
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
