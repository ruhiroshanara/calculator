namespace Calculator
{
    [TestClass]
    public class Addition
    {
        [TestMethod]
        public void Add()

        {
            int expected = 24;
            int number1 = 20;
            int number2 = 4;

            int actual = Arthimetic.Calculator.Addition(number1, number2);
            Assert.AreEqual(expected, actual);
        }
    }
}
