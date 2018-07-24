using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using NUnit.Framework;

public static partial class TEST
{
    /// <summary>
    /// <see cref="FractionManager"/>クラスのテスト
    /// </summary>
    public static class FractionManagerTest
    {
        [Test]
        public static void LimitUpperTest()
        {
            Assert.AreEqual(new Fraction(17, 3), FractionManager.LimitUpper(new Fraction(17, 3), new Fraction(52, 4)));
            Assert.AreEqual(new Fraction(54, 6), FractionManager.LimitUpper(new Fraction(102, 5), new Fraction(54, 6)));
        }
        [Test]
        public static void LimitLowerTest()
        {
            Assert.AreEqual(new Fraction(52, 4), FractionManager.LimitLower(new Fraction(17, 3), new Fraction(52, 4)));
            Assert.AreEqual(new Fraction(92, 5), FractionManager.LimitLower(new Fraction(92, 5), new Fraction(54, 6)));
        }
    }
}
