using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Service;
using NUnit.Framework;

namespace Assets.Editor.TEST.Domain.Model.Value
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

            percentage1.numer.Is(percentage2.numer);
            percentage1.denom.Is(percentage2.denom);
            percentage1.value.Is(percentage2.value);
        }
        [Test]
        public static void OneTest()
        {
            var percentage1 = 1.ToPercentage();
            var percentage2 = Percentage.one;

            percentage1.numer.Is(percentage2.numer);
            percentage1.denom.Is(percentage2.denom);
            percentage1.value.Is(percentage2.value);
        }
        [Test]
        public static void NewPercentageTest()
        {
            var percentage1 = 3.ToPercentage();
            var percentage2 = -3.ToPercentage();
            var percentage3 = 6.ToPercentage();
            var percentage4 = 109.ToPercentage();

            percentage1.value.Is(0.03f);
            percentage2.value.Is(-0.03f);
            percentage3.value.Is(0.06f);
            percentage4.value.Is(1.09f);
        }
    }
}
