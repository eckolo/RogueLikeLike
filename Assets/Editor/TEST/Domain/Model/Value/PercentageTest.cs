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
        public static void NewFractionTest()
        {
            var fraction1 = 3.ToPercentage();
            var fraction2 = -3.ToPercentage();
            var fraction3 = 6.ToPercentage();
            var fraction4 = 109.ToPercentage();

            Assert.AreEqual(0.03f, fraction1.value);
            Assert.AreEqual(-0.03f, fraction2.value);
            Assert.AreEqual(0.06f, fraction3.value);
            Assert.AreEqual(1.09f, fraction4.value);
        }
    }
}
