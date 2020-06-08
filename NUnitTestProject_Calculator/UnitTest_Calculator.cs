using NUnit.Framework;
using StringCalculator_Jerald;

namespace Tests
{
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Test1()
        {
            int answer = calculator.Add("");
            int expected = 0;
            Assert.AreEqual(expected, answer);
        }

        [Test]
        public void Test2()
        {
            int answer = calculator.Add("1,2,3");
            int expected = 6;
            Assert.AreEqual(expected, answer);
        }

        [Test]
        public void Test3()
        {
            int answer = calculator.Add("1\n,2,3");
            int expected = 6;
            Assert.AreEqual(expected, answer);
        }

        [Test]
        public void Test4()
        {
            int answer = calculator.Add("1,\n2,4");
            int expected = 7;
            Assert.AreEqual(expected, answer);
        }

        [Test]
        public void Test5()
        {
            int answer = calculator.Add("//;\n1;3;4");
            int expected = 8;
            Assert.AreEqual(expected, answer);
        }

        [Test]
        public void Test6()
        {
            int answer = calculator.Add("//$\n1$2$3");
            int expected = 6;
            Assert.AreEqual(expected, answer);
        }

        [Test]
        public void Test7()
        {
            int answer = calculator.Add("//@\n2@3@8");
            int expected = 13;
            Assert.AreEqual(expected, answer);
        }

        [Test]
        //Test for Negative number
        public void Test8()
        {
            int answer = calculator.Add("-1");
            int expected = -1;
            Assert.AreEqual(expected, answer);
        }

        [Test]
        //Test for numbers larger than 1000
        public void Test9()
        {
            int answer = calculator.Add("//@\n2@5@1001");
            int expected = 7;
            Assert.AreEqual(expected, answer);
        }

        [Test]
        //Test for Delimters of arbitrary length
        public void Test10()
        {
            int answer = calculator.Add("//***\n1***2***3");
            int expected = 6;
            Assert.AreEqual(expected, answer);
        }
    }
}