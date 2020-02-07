using NUnit.Framework;
using NUnitCalcTest.CalcLib;

namespace Tests
{
    public class Tests
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }
        [Test]
        public void TestefloatImc()
        {
            float peso = 70.0f;
            float altura = 1.75f;
            float result = 22.86f;

            float actual = calc.floatImc(peso, altura);
            Assert.AreEqual(result, actual);
        }

        [Test]
        public void TestedoubleImc()
        {
            double peso = 70.0;
            double altura = 1.75;
            double result = 22.86d;

            double actual = calc.doubleImc(peso, altura);
            Assert.AreEqual(result, actual);
        }

    }
}  
      