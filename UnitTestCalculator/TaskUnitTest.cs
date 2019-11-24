using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorChallenge;

namespace UnitTestCalculator
{
    [TestClass]
    public class TaskUnitTest
    {
        //[TestMethod]
        //public void ValidateArrayLength()
        //{
        //    var numbers = "9,rrrr,";
        //    var result = "You entered more than 2 numbers. Please enter only two numbers (,) seprated.";

        //    Calculator calc = new Calculator(numbers);

        //    var actualResult = calc.validateNumber();

        //    Assert.AreEqual(result, actualResult);
        //}

        [TestMethod]
        public void AddNumbers1() 
        {
            var numbers = "9,rrrr";
            var result = 9;

            Calculator calc = new Calculator(numbers);

            var validate = calc.validateNumber();
            var sum = 0;

            if (validate == "valid")
            {
                sum = calc.addNumber();
            }

            Assert.AreEqual(result, sum);

        }

        [TestMethod]
        public void AddNumbers0()
        {
            var numbers = "4,-3";
            var result = "Please provide +ve integer values";

            Calculator calc = new Calculator(numbers);

            var validate = calc.validateNumber();
            //var sum = 0;

            //if (validate == "valid")
            //{
            //    sum = calc.addNumber();
            //}

            Assert.AreEqual(result, validate);

        }

        [TestMethod]
        public void AddNumbers2()
        {
            var numbers = ",rrrr";
            var result = 0;

            Calculator calc = new Calculator(numbers);

            var validate = calc.validateNumber();
            var sum = 0;

            if (validate == "valid")
            {
                sum = calc.addNumber();
            }

            Assert.AreEqual(result, sum);

        }

        [TestMethod]
        public void AddNumbers3()
        {
            var numbers = "2";
            var result = 2;

            Calculator calc = new Calculator(numbers);

            var validate = calc.validateNumber();
            var sum = 0;

            if (validate == "valid")
            {
                sum = calc.addNumber();
            }

            Assert.AreEqual(result, sum);

        }

        [TestMethod]
        public void AddNumbers4()
        {
            var numbers = "9,5000";
            var result = 9;

            Calculator calc = new Calculator(numbers);

            var validate = calc.validateNumber();
            var sum = 0;

            if (validate == "valid")
            {
                sum = calc.addNumber();
            }

            Assert.AreEqual(result, sum);

        }

        [TestMethod]
        public void AddNumbersArray()
        {
            var numbers = "1,2,3,4,5,6,7,8,9,10,11,12";
            var result = 78;

            Calculator calc = new Calculator(numbers);

            var validate = calc.validateNumber();
            var sum = 0;

            if (validate == "valid")
            {
                sum = calc.addNumber();
            }

            Assert.AreEqual(result, sum);

        }

        [TestMethod]
        public void AddNumbersNewDelimeter()
        {
            var numbers = @"1\n2,3";
            var result = 6;

            Calculator calc = new Calculator(numbers);

            var validate = calc.validateNumber();
            var sum = 0;

            if (validate == "valid")
            {
                sum = calc.addNumber();
            }

            Assert.AreEqual(result, sum);

        }

        [TestMethod]
        public void AddNumbers1000Check()
        {
            var numbers = "2,1000,6";
            var result = 8;

            Calculator calc = new Calculator(numbers);

            var validate = calc.validateNumber();
            var sum = 0;

            if (validate == "valid")
            {
                sum = calc.addNumber();
            }

            Assert.AreEqual(result, sum);

        }


        [TestMethod]
        public void AddNumbersNewCharacterCheck()
        {
            var numbers = @"//#\n2#5";
            var result = 7;

            Calculator calc = new Calculator(numbers);

            var validate = calc.validateNumber();
            var sum = 0;

            if (validate == "valid")
            {
                sum = calc.addNumber();
            }

            Assert.AreEqual(result, sum);

        }

        [TestMethod]
        public void AddNumbersNewCharacterCheck2()
        {
            var numbers = @"//,\n2,ff,200";
            var result = 102;

            Calculator calc = new Calculator(numbers);

            var validate = calc.validateNumber();
            var sum = 0;

            if (validate == "valid")
            {
                sum = calc.addNumber();
            }

            Assert.AreEqual(result, sum);

        }


    }
}
