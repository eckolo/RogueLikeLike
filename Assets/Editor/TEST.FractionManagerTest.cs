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
        public static void UpperTest1()
        {
            Assert.AreEqual(new Fraction(17, 3), FractionManager.Upper(new Fraction(17, 3), new Fraction(52, 4)));
            Assert.AreEqual(new Fraction(54, 6), FractionManager.Upper(new Fraction(102, 5), new Fraction(54, 6)));
        }
        [Test]
        public static void LowerTest1()
        {
            Assert.AreEqual(new Fraction(52, 4), FractionManager.Lower(new Fraction(17, 3), new Fraction(52, 4)));
            Assert.AreEqual(new Fraction(102, 5), FractionManager.Lower(new Fraction(102, 5), new Fraction(54, 6)));
        }
    }
}
