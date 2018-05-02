using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public static partial class TEST
{
    /// <summary>
    /// 文字列処理サービスのテスト
    /// </summary>
    public static class SpecifiedRangeTest
    {
        [Test]
        public static void EnumerateTargetPointListTest()
        {
            var binding = BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Instance;
            var map = new Dictionary<Vector2, int> { { new Vector2(-2, 3), 3 }, { new Vector2(1, 2), 3 } };

            var range = SpecifiedRange.one;
            range.GetType().GetField("_targetPointRadiusList", binding).SetValue(range, map);

            var result = range.EnumerateTargetPointList();

            #region AssertEveryPoint

            Assert.IsFalse(result.Contains(new Vector2(-6, -2)));
            Assert.IsFalse(result.Contains(new Vector2(-5, -2)));
            Assert.IsFalse(result.Contains(new Vector2(-4, -2)));
            Assert.IsFalse(result.Contains(new Vector2(-3, -2)));
            Assert.IsFalse(result.Contains(new Vector2(-2, -2)));
            Assert.IsFalse(result.Contains(new Vector2(-1, -2)));
            Assert.IsFalse(result.Contains(new Vector2(0, -2)));
            Assert.IsFalse(result.Contains(new Vector2(1, -2)));
            Assert.IsFalse(result.Contains(new Vector2(2, -2)));
            Assert.IsFalse(result.Contains(new Vector2(3, -2)));
            Assert.IsFalse(result.Contains(new Vector2(4, -2)));
            Assert.IsFalse(result.Contains(new Vector2(5, -2)));
            Assert.IsFalse(result.Contains(new Vector2(-6, -1)));
            Assert.IsFalse(result.Contains(new Vector2(-5, -1)));
            Assert.IsFalse(result.Contains(new Vector2(-4, -1)));
            Assert.IsFalse(result.Contains(new Vector2(-3, -1)));
            Assert.IsFalse(result.Contains(new Vector2(-2, -1)));
            Assert.IsFalse(result.Contains(new Vector2(-1, -1)));
            Assert.IsTrue(result.Contains(new Vector2(0, -1)));
            Assert.IsTrue(result.Contains(new Vector2(1, -1)));
            Assert.IsTrue(result.Contains(new Vector2(2, -1)));
            Assert.IsFalse(result.Contains(new Vector2(3, -1)));
            Assert.IsFalse(result.Contains(new Vector2(4, -1)));
            Assert.IsFalse(result.Contains(new Vector2(5, -1)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 0)));
            Assert.IsFalse(result.Contains(new Vector2(-5, 0)));
            Assert.IsFalse(result.Contains(new Vector2(-4, 0)));
            Assert.IsTrue(result.Contains(new Vector2(-3, 0)));
            Assert.IsTrue(result.Contains(new Vector2(-2, 0)));
            Assert.IsTrue(result.Contains(new Vector2(-1, 0)));
            Assert.IsTrue(result.Contains(new Vector2(0, 0)));
            Assert.IsTrue(result.Contains(new Vector2(1, 0)));
            Assert.IsTrue(result.Contains(new Vector2(2, 0)));
            Assert.IsTrue(result.Contains(new Vector2(3, 0)));
            Assert.IsFalse(result.Contains(new Vector2(4, 0)));
            Assert.IsFalse(result.Contains(new Vector2(5, 0)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 1)));
            Assert.IsFalse(result.Contains(new Vector2(-5, 1)));
            Assert.IsTrue(result.Contains(new Vector2(-4, 1)));
            Assert.IsTrue(result.Contains(new Vector2(-3, 1)));
            Assert.IsTrue(result.Contains(new Vector2(-2, 1)));
            Assert.IsTrue(result.Contains(new Vector2(-1, 1)));
            Assert.IsTrue(result.Contains(new Vector2(0, 1)));
            Assert.IsTrue(result.Contains(new Vector2(1, 1)));
            Assert.IsTrue(result.Contains(new Vector2(2, 1)));
            Assert.IsTrue(result.Contains(new Vector2(3, 1)));
            Assert.IsTrue(result.Contains(new Vector2(4, 1)));
            Assert.IsFalse(result.Contains(new Vector2(5, 1)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 2)));
            Assert.IsTrue(result.Contains(new Vector2(-5, 2)));
            Assert.IsTrue(result.Contains(new Vector2(-4, 2)));
            Assert.IsTrue(result.Contains(new Vector2(-3, 2)));
            Assert.IsTrue(result.Contains(new Vector2(-2, 2)));
            Assert.IsTrue(result.Contains(new Vector2(-1, 2)));
            Assert.IsTrue(result.Contains(new Vector2(0, 2)));
            Assert.IsTrue(result.Contains(new Vector2(1, 2)));
            Assert.IsTrue(result.Contains(new Vector2(2, 2)));
            Assert.IsTrue(result.Contains(new Vector2(3, 2)));
            Assert.IsTrue(result.Contains(new Vector2(4, 2)));
            Assert.IsFalse(result.Contains(new Vector2(5, 2)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 3)));
            Assert.IsTrue(result.Contains(new Vector2(-5, 3)));
            Assert.IsTrue(result.Contains(new Vector2(-4, 3)));
            Assert.IsTrue(result.Contains(new Vector2(-3, 3)));
            Assert.IsTrue(result.Contains(new Vector2(-2, 3)));
            Assert.IsTrue(result.Contains(new Vector2(-1, 3)));
            Assert.IsTrue(result.Contains(new Vector2(0, 3)));
            Assert.IsTrue(result.Contains(new Vector2(1, 3)));
            Assert.IsTrue(result.Contains(new Vector2(2, 3)));
            Assert.IsTrue(result.Contains(new Vector2(3, 3)));
            Assert.IsTrue(result.Contains(new Vector2(4, 3)));
            Assert.IsFalse(result.Contains(new Vector2(5, 3)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 4)));
            Assert.IsTrue(result.Contains(new Vector2(-5, 4)));
            Assert.IsTrue(result.Contains(new Vector2(-4, 4)));
            Assert.IsTrue(result.Contains(new Vector2(-3, 4)));
            Assert.IsTrue(result.Contains(new Vector2(-2, 4)));
            Assert.IsTrue(result.Contains(new Vector2(-1, 4)));
            Assert.IsTrue(result.Contains(new Vector2(0, 4)));
            Assert.IsTrue(result.Contains(new Vector2(1, 4)));
            Assert.IsTrue(result.Contains(new Vector2(2, 4)));
            Assert.IsTrue(result.Contains(new Vector2(3, 4)));
            Assert.IsFalse(result.Contains(new Vector2(4, 4)));
            Assert.IsFalse(result.Contains(new Vector2(5, 4)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 5)));
            Assert.IsFalse(result.Contains(new Vector2(-5, 5)));
            Assert.IsTrue(result.Contains(new Vector2(-4, 5)));
            Assert.IsTrue(result.Contains(new Vector2(-3, 5)));
            Assert.IsTrue(result.Contains(new Vector2(-2, 5)));
            Assert.IsTrue(result.Contains(new Vector2(-1, 5)));
            Assert.IsTrue(result.Contains(new Vector2(0, 5)));
            Assert.IsTrue(result.Contains(new Vector2(1, 5)));
            Assert.IsTrue(result.Contains(new Vector2(2, 5)));
            Assert.IsFalse(result.Contains(new Vector2(3, 5)));
            Assert.IsFalse(result.Contains(new Vector2(4, 5)));
            Assert.IsFalse(result.Contains(new Vector2(5, 5)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 6)));
            Assert.IsFalse(result.Contains(new Vector2(-5, 6)));
            Assert.IsFalse(result.Contains(new Vector2(-4, 6)));
            Assert.IsTrue(result.Contains(new Vector2(-3, 6)));
            Assert.IsTrue(result.Contains(new Vector2(-2, 6)));
            Assert.IsTrue(result.Contains(new Vector2(-1, 6)));
            Assert.IsFalse(result.Contains(new Vector2(0, 6)));
            Assert.IsFalse(result.Contains(new Vector2(1, 6)));
            Assert.IsFalse(result.Contains(new Vector2(2, 6)));
            Assert.IsFalse(result.Contains(new Vector2(3, 6)));
            Assert.IsFalse(result.Contains(new Vector2(4, 6)));
            Assert.IsFalse(result.Contains(new Vector2(5, 6)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 7)));
            Assert.IsFalse(result.Contains(new Vector2(-5, 7)));
            Assert.IsFalse(result.Contains(new Vector2(-4, 7)));
            Assert.IsFalse(result.Contains(new Vector2(-3, 7)));
            Assert.IsFalse(result.Contains(new Vector2(-2, 7)));
            Assert.IsFalse(result.Contains(new Vector2(-1, 7)));
            Assert.IsFalse(result.Contains(new Vector2(0, 7)));
            Assert.IsFalse(result.Contains(new Vector2(1, 7)));
            Assert.IsFalse(result.Contains(new Vector2(2, 7)));
            Assert.IsFalse(result.Contains(new Vector2(3, 7)));
            Assert.IsFalse(result.Contains(new Vector2(4, 7)));
            Assert.IsFalse(result.Contains(new Vector2(5, 7)));

            #endregion
        }
        [Test]
        public static void OnTargetTest()
        {
            var binding = BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Instance;
            var map = new Dictionary<Vector2, int> { { new Vector2(-2, 3), 3 }, { new Vector2(1, 2), 3 } };

            var range = SpecifiedRange.one;
            range.GetType().GetField("_targetPointRadiusList", binding).SetValue(range, map);

            var point1 = new Vector2(-2, 3);
            var point2 = new Vector2(1, 2);
            var point3 = new Vector2(-3, 4);
            var point4 = new Vector2(-1, 1);
            var point5 = new Vector2(5, 4);

            Assert.IsTrue(range.OnTarget(point1));
            Assert.IsTrue(range.OnTarget(point2));
            Assert.IsTrue(range.OnTarget(point3));
            Assert.IsTrue(range.OnTarget(point4));
            Assert.IsFalse(range.OnTarget(point5));
        }
    }
}
