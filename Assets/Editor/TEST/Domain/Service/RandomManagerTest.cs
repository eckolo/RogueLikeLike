using Assets.Src.Domain.Service;
using NUnit.Framework;

namespace Assets.Editor.TEST.Domain.Service
{
    /// <summary>
    /// <see cref="RandomManager"/>クラスのテスト
    /// </summary>
    public static class RandomManagerTest
    {
        [Test]
        public static void ConvertSnakeToPascalTest()
        {
            for(int index = 0; index < 10000; index++)
            {
                var result = 21.SetupRandomNorm().value;

                Assert.IsTrue(0 <= result && result < 1);
            }
        }
    }
}
