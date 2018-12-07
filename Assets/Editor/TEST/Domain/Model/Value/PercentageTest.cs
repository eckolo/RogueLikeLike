using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Service;
using NUnit.Framework;

namespace TEST.Domain.Model.Value
{
    /// <summary>
    /// <see cref="Percentage"/>クラスのテスト
    /// </summary>
    public static class PercentageTest
    {
        [Test]
        public static void ZeroTest()
        {
            var percentage1 = 0.ToPercentage();
            var percentage2 = Percentage.zero;

            Assert.AreEqual(percentage1.numer, percentage2.numer);
            Assert.AreEqual(percentage1.denom, percentage2.denom);
            Assert.AreEqual(percentage1.value, percentage2.value);
        }
        [Test]
        public static void OneTest()
        {
            var percentage1 = 1.ToPercentage();
            var percentage2 = Percentage.one;

            Assert.AreEqual(percentage1.numer, percentage2.numer);
            Assert.AreEqual(percentage1.denom, percentage2.denom);
            Assert.AreEqual(percentage1.value, percentage2.value);
        }
        [Test]
        public static void NewPercentageTest()
        {
            var percentage1 = 3.ToPercentage();
            var percentage2 = -3.ToPercentage();
            var percentage3 = 6.ToPercentage();
            var percentage4 = 109.ToPercentage();

            Assert.AreEqual(0.03f, percentage1.value);
            Assert.AreEqual(-0.03f, percentage2.value);
            Assert.AreEqual(0.06f, percentage3.value);
            Assert.AreEqual(1.09f, percentage4.value);
        }
    }
}
