using Assets.Src.Domains;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public static partial class TEST
{
    /// <summary>
    /// リスト関連の汎用操作クラスのテスト
    /// </summary>
    public static class EnumerableManagerTest
    {
        [Test]
        public static void MaxKeysTest()
        {
            var list = new List<Vector2> { new Vector2(2, 2), new Vector2(6, -8), new Vector2(-6, 8), new Vector2(0, -1) };

            var result = list.MaxKeys(elem => elem.magnitude);
            Assert.AreEqual(result.Count(), 2);

            var resultFirst = result.Single(elem => elem.x > 0);
            var resultSecond = result.Single(elem => elem.x < 0);
            Assert.AreEqual(resultFirst.x, 6);
            Assert.AreEqual(resultFirst.y, -8);
            Assert.AreEqual(resultSecond.x, -6);
            Assert.AreEqual(resultSecond.y, 8);
        }
    }
}
