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
            Assert.AreEqual(17.DividedBy(3), FractionManager.LimitUpper(17.DividedBy(3), 52.DividedBy(4)));
            Assert.AreEqual(54.DividedBy(6), FractionManager.LimitUpper(102.DividedBy(5), 54.DividedBy(6)));
        }
        [Test]
        public static void LimitLowerTest()
        {
            Assert.AreEqual(52.DividedBy(4), FractionManager.LimitLower(17.DividedBy(3), 52.DividedBy(4)));
            Assert.AreEqual(92.DividedBy(5), FractionManager.LimitLower(92.DividedBy(5), 54.DividedBy(6)));
        }
    }
}
