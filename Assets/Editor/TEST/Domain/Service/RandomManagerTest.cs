using Assets.Src.Domains.Service;
using NUnit.Framework;
using UnityEngine;

namespace TEST.Domain.Service
{
    /// <summary>
    /// <see cref="RandomManager"/>クラスのテスト
    /// </summary>
    public static class RandomManagerTest
    {
        [Test]
        public static void ConvertSnakeToPascalTest()
        {
            Random.InitState(3);
            var state = Random.state;
            for(int index = 0; index < 10000; index++)
            {
                var result1 = state.SetupRandomNorm().value;
                var result2 = state.SetupRandomNorm(21).value;

                Assert.IsTrue(0 <= result1 && result1 < 1);
                Assert.IsTrue(0 <= result2 && result2 < 1);
            }
        }
    }
}
