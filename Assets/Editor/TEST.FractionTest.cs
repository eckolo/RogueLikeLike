using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using NUnit.Framework;
public static partial class TEST
{
    /// <summary>
    /// <see cref="Fraction"/>クラスのテスト
    /// </summary>
    public static class FractionTest
    {
        [Test]
        public static void ZeroTest()
        {
            var fraction1 = 0.ToFraction();
            var fraction2 = Fraction.zero;

            Assert.AreEqual(fraction1.numer, fraction2.numer);
            Assert.AreEqual(fraction1.denom, fraction2.denom);
            Assert.AreEqual(fraction1.value, fraction2.value);
        }
        [Test]
        public static void OneTest()
        {
            var fraction1 = 1.ToFraction();
            var fraction2 = Fraction.one;

            Assert.AreEqual(fraction1.numer, fraction2.numer);
            Assert.AreEqual(fraction1.denom, fraction2.denom);
            Assert.AreEqual(fraction1.value, fraction2.value);
        }
        [Test]
        public static void NewFractionTest()
        {
            var fraction1 = 3.ToFraction();
            var fraction2 = 3.DividedBy(1);
            var fraction3 = 6.DividedBy(2);
            var fraction4 = 9.DividedBy(-3);

            Assert.AreEqual(fraction1.numer, fraction2.numer);
            Assert.AreEqual(fraction1.denom, fraction2.denom);
            Assert.AreEqual(fraction3.numer, fraction2.numer);
            Assert.AreEqual(fraction3.denom, fraction2.denom);
            Assert.AreEqual(3, fraction1.value);
            Assert.AreEqual(3, fraction2.value);
            Assert.AreEqual(3, fraction3.value);
            Assert.AreEqual(-3, fraction4.value);
        }
        [Test]
        public static void CompareTest()
        {
            var fraction1 = 4.DividedBy(5);
            var fraction2 = 7.DividedBy(2);
            var fraction3 = 3.DividedBy(-8);
            var fraction4 = 4.DividedBy(5);
            var value1 = 3f;
            var value2 = -12;

            Assert.IsFalse(fraction1 == fraction2);
            Assert.IsTrue(fraction1 != fraction2);
            Assert.IsTrue(fraction1 < fraction2);
            Assert.IsFalse(fraction1 > fraction2);
            Assert.IsTrue(fraction1 <= fraction2);
            Assert.IsFalse(fraction1 >= fraction2);

            Assert.IsFalse(fraction1 == fraction3);
            Assert.IsTrue(fraction1 != fraction3);
            Assert.IsFalse(fraction1 < fraction3);
            Assert.IsTrue(fraction1 > fraction3);
            Assert.IsFalse(fraction1 <= fraction3);
            Assert.IsTrue(fraction1 >= fraction3);

            Assert.IsTrue(fraction1 == fraction4);
            Assert.IsFalse(fraction1 != fraction4);
            Assert.IsFalse(fraction1 < fraction4);
            Assert.IsFalse(fraction1 > fraction4);
            Assert.IsTrue(fraction1 <= fraction4);
            Assert.IsTrue(fraction1 >= fraction4);

            Assert.IsFalse(fraction1 == value1);
            Assert.IsTrue(fraction1 != value1);
            Assert.IsTrue(fraction1 < value1);
            Assert.IsFalse(fraction1 > value1);
            Assert.IsTrue(fraction1 <= value1);
            Assert.IsFalse(fraction1 >= value1);

            Assert.IsFalse(fraction1 == value2);
            Assert.IsTrue(fraction1 != value2);
            Assert.IsFalse(fraction1 < value2);
            Assert.IsTrue(fraction1 > value2);
            Assert.IsFalse(fraction1 <= value2);
            Assert.IsTrue(fraction1 >= value2);
        }
        [Test]
        public static void NegativeValueTest()
        {
            var fraction1 = 4.DividedBy(5);
            var fraction2 = 7.DividedBy(2);
            var fraction3 = 3.DividedBy(-8);

            var result1 = -fraction1;
            var result2 = -fraction2;
            var result3 = -fraction3;

            Assert.AreEqual(-4, result1.numer);
            Assert.AreEqual(5, result1.denom);
            Assert.AreEqual(-0.8f, result1.value);
            Assert.AreEqual(-7, result2.numer);
            Assert.AreEqual(2, result2.denom);
            Assert.AreEqual(-3.5f, result2.value);
            Assert.AreEqual(3, result3.numer);
            Assert.AreEqual(8, result3.denom);
            Assert.AreEqual(0.375f, result3.value);
        }
        [Test]
        public static void AdditionTest()
        {
            var fraction1 = 4.DividedBy(5);
            var fraction2 = 7.DividedBy(2);
            var fraction3 = 3.DividedBy(-8);
            var value1 = 3;
            var value2 = -12;

            var result1 = fraction1 + fraction2;
            var result2 = fraction1 + fraction3;
            var result3 = fraction1 + value1;
            var result4 = fraction1 + value2;
            var result5 = value2 + fraction1;

            Assert.AreEqual(43, result1.numer);
            Assert.AreEqual(10, result1.denom);
            Assert.AreEqual(4.3f, result1.value);
            Assert.AreEqual(17, result2.numer);
            Assert.AreEqual(40, result2.denom);
            Assert.AreEqual(0.425f, result2.value);
            Assert.AreEqual(19, result3.numer);
            Assert.AreEqual(5, result3.denom);
            Assert.AreEqual(3.8f, result3.value);
            Assert.AreEqual(-56, result4.numer);
            Assert.AreEqual(5, result4.denom);
            Assert.AreEqual(-11.2f, result4.value);
            Assert.AreEqual(-56, result5.numer);
            Assert.AreEqual(5, result5.denom);
            Assert.AreEqual(-11.2f, result5.value);
        }
        [Test]
        public static void SubtractionTest()
        {
            var fraction1 = 4.DividedBy(5);
            var fraction2 = 7.DividedBy(2);
            var fraction3 = 3.DividedBy(-8);
            var value1 = 3;
            var value2 = -12;

            var result1 = fraction1 - fraction2;
            var result2 = fraction1 - fraction3;
            var result3 = fraction1 - value1;
            var result4 = fraction1 - value2;
            var result5 = value2 - fraction1;

            Assert.AreEqual(-27, result1.numer);
            Assert.AreEqual(10, result1.denom);
            Assert.AreEqual(-2.7f, result1.value);
            Assert.AreEqual(47, result2.numer);
            Assert.AreEqual(40, result2.denom);
            Assert.AreEqual(47f / 40f, result2.value);
            Assert.AreEqual(-11, result3.numer);
            Assert.AreEqual(5, result3.denom);
            Assert.AreEqual(-2.2f, result3.value);
            Assert.AreEqual(64, result4.numer);
            Assert.AreEqual(5, result4.denom);
            Assert.AreEqual(12.8f, result4.value);
            Assert.AreEqual(-64, result5.numer);
            Assert.AreEqual(5, result5.denom);
            Assert.AreEqual(-12.8f, result5.value);
        }
        [Test]
        public static void MultiplicationTest()
        {
            var fraction1 = 4.DividedBy(5);
            var fraction2 = 7.DividedBy(2);
            var fraction3 = 3.DividedBy(-8);
            var value1 = 3;
            var value2 = -12;

            var result1 = fraction1 * fraction2;
            var result2 = fraction1 * fraction3;
            var result3 = fraction1 * value1;
            var result4 = fraction1 * value2;
            var result5 = value2 * fraction1;

            Assert.AreEqual(14, result1.numer);
            Assert.AreEqual(5, result1.denom);
            Assert.AreEqual(2.8f, result1.value);
            Assert.AreEqual(-3, result2.numer);
            Assert.AreEqual(10, result2.denom);
            Assert.AreEqual(-0.3f, result2.value);
            Assert.AreEqual(12, result3.numer);
            Assert.AreEqual(5, result3.denom);
            Assert.AreEqual(2.4f, result3.value);
            Assert.AreEqual(-48, result4.numer);
            Assert.AreEqual(5, result4.denom);
            Assert.AreEqual(-9.6f, result4.value);
            Assert.AreEqual(-48, result5.numer);
            Assert.AreEqual(5, result5.denom);
            Assert.AreEqual(-9.6f, result5.value);
        }
        [Test]
        public static void DivisionTest()
        {
            var fraction1 = 4.DividedBy(5);
            var fraction2 = 7.DividedBy(2);
            var fraction3 = 3.DividedBy(-8);
            var value1 = 3;
            var value2 = -12;

            var result1 = fraction1 / fraction2;
            var result2 = fraction1 / fraction3;
            var result3 = fraction1 / value1;
            var result4 = fraction1 / value2;
            var result5 = value2 / fraction1;

            Assert.AreEqual(8, result1.numer);
            Assert.AreEqual(35, result1.denom);
            Assert.AreEqual(8f / 35f, result1.value);
            Assert.AreEqual(-32, result2.numer);
            Assert.AreEqual(15, result2.denom);
            Assert.AreEqual(-32f / 15f, result2.value);
            Assert.AreEqual(4, result3.numer);
            Assert.AreEqual(15, result3.denom);
            Assert.AreEqual(4f / 15f, result3.value);
            Assert.AreEqual(-1, result4.numer);
            Assert.AreEqual(15, result4.denom);
            Assert.AreEqual(-1f / 15f, result4.value);
            Assert.AreEqual(-15, result5.numer);
            Assert.AreEqual(1, result5.denom);
            Assert.AreEqual(-15, result5.value);
        }
    }
}
