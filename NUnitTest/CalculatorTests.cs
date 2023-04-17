namespace NUnitTest
{
    [TestFixture, Description("Calculator tests")]
    public class Tests
    {
        Calculator calculator;
        [OneTimeSetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 2, 3)]
        [TestCase(-1, -2, -3)]
        public void SummTest(int operand1, int operand2, int expectedResult)
        {
            var actualResult = calculator.Summ(operand1, operand2);
            Assert.That(actualResult, Is.EqualTo(expectedResult), $"Result failed");
        }

        [TestCase(2, 1, ExpectedResult = 1)]
        [TestCase(-1, -2, ExpectedResult = 1)]
        [TestCase(1, -2, ExpectedResult = 3)]
        [TestCase(-1, 2, ExpectedResult = -3)]
        public double MinusTest(int operand1, int operand2)
        {
            var actualResult = calculator.Minus(operand1, operand2);
            return actualResult;
        }

        [Test]
        [Category("MultiplyTest")]
        public void MultiplyTest(
            [Values(1, 10)] int operand1, 
            [Range(0, 5, 1)] int operand2)
        {
            var actualResult = calculator.Multiply(operand1, operand2);
            Assert.That(actualResult, Is.EqualTo(-actualResult), $"Result failed");
        }

        [Retry(2)]
        [Test]
        public void DevideTest(
            [Values(1, 2)] int operand1,
            [Random(0, 5, 1)] int operand2)
        {
            var actualResult = calculator.Devide(operand1, operand2);
            Assert.That(actualResult, Is.EqualTo(-actualResult), $"Result failed");
        }

        [TearDown]
        public void CleanUp() 
        {
        }
    }
}