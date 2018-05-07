using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public static partial class TEST
{
    /// <summary>
    /// <see cref="Coverage"/>サービスのテスト
    /// </summary>
    public static class CoverageTest
    {
        [Test]
        public static void EnumerateTargetPointListTest()
        {
            var binding = BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Instance;
            var map1 = new Dictionary<Vector2, int> {
                { new Vector2(-2, 3), 3 },
                { new Vector2(1, 2), 3 }
            };
            var map2 = new Dictionary<Vector2, int> {
                { new Vector2(0, 0), 2 }
            };

            var range = Coverage.zero;
            range.GetType().GetField("_targetRanges", binding).SetValue(range, map1);
            range.GetType().GetField("_excludeRanges", binding).SetValue(range, map2);

            var result = range.EnumerateTargetPoints().ToList();

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
            Assert.IsFalse(result.Contains(new Vector2(0, -1)));
            Assert.IsFalse(result.Contains(new Vector2(1, -1)));
            Assert.IsFalse(result.Contains(new Vector2(2, -1)));
            Assert.IsFalse(result.Contains(new Vector2(3, -1)));
            Assert.IsFalse(result.Contains(new Vector2(4, -1)));
            Assert.IsFalse(result.Contains(new Vector2(5, -1)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 0)));
            Assert.IsFalse(result.Contains(new Vector2(-5, 0)));
            Assert.IsFalse(result.Contains(new Vector2(-4, 0)));
            Assert.IsTrue(result.Contains(new Vector2(-3, 0)));
            Assert.IsFalse(result.Contains(new Vector2(-2, 0)));
            Assert.IsFalse(result.Contains(new Vector2(-1, 0)));
            Assert.IsFalse(result.Contains(new Vector2(0, 0)));
            Assert.IsFalse(result.Contains(new Vector2(1, 0)));
            Assert.IsFalse(result.Contains(new Vector2(2, 0)));
            Assert.IsTrue(result.Contains(new Vector2(3, 0)));
            Assert.IsFalse(result.Contains(new Vector2(4, 0)));
            Assert.IsFalse(result.Contains(new Vector2(5, 0)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 1)));
            Assert.IsFalse(result.Contains(new Vector2(-5, 1)));
            Assert.IsTrue(result.Contains(new Vector2(-4, 1)));
            Assert.IsTrue(result.Contains(new Vector2(-3, 1)));
            Assert.IsFalse(result.Contains(new Vector2(-2, 1)));
            Assert.IsFalse(result.Contains(new Vector2(-1, 1)));
            Assert.IsFalse(result.Contains(new Vector2(0, 1)));
            Assert.IsFalse(result.Contains(new Vector2(1, 1)));
            Assert.IsFalse(result.Contains(new Vector2(2, 1)));
            Assert.IsTrue(result.Contains(new Vector2(3, 1)));
            Assert.IsTrue(result.Contains(new Vector2(4, 1)));
            Assert.IsFalse(result.Contains(new Vector2(5, 1)));
            Assert.IsFalse(result.Contains(new Vector2(-6, 2)));
            Assert.IsTrue(result.Contains(new Vector2(-5, 2)));
            Assert.IsTrue(result.Contains(new Vector2(-4, 2)));
            Assert.IsTrue(result.Contains(new Vector2(-3, 2)));
            Assert.IsTrue(result.Contains(new Vector2(-2, 2)));
            Assert.IsFalse(result.Contains(new Vector2(-1, 2)));
            Assert.IsFalse(result.Contains(new Vector2(0, 2)));
            Assert.IsFalse(result.Contains(new Vector2(1, 2)));
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
        public static void EnumerateTargetPointListTest2()
        {
            var binding = BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Instance;
            var map1 = new Dictionary<Vector2, int> {
                { new Vector2(-2, 3), 3 },//4,0
                { new Vector2(1, 2), 3 }//3,-3
            };
            var map2 = new Dictionary<Vector2, int> {
                { new Vector2(0, 0), 2 }//1,-2
            };

            var range = Coverage.zero;
            range.GetType().GetField("_targetRanges", binding).SetValue(range, map1);
            range.GetType().GetField("_excludeRanges", binding).SetValue(range, map2);

            var result = range.Move(new Vector2(1, -2), Direction.WEST).EnumerateTargetPoints().ToList();

            #region AssertEveryPoint

            Assert.IsFalse(result.Contains(new Vector2(-1, -7)));
            Assert.IsFalse(result.Contains(new Vector2(0, -7)));
            Assert.IsFalse(result.Contains(new Vector2(1, -7)));
            Assert.IsFalse(result.Contains(new Vector2(2, -7)));
            Assert.IsFalse(result.Contains(new Vector2(3, -7)));
            Assert.IsFalse(result.Contains(new Vector2(4, -7)));
            Assert.IsFalse(result.Contains(new Vector2(5, -7)));
            Assert.IsFalse(result.Contains(new Vector2(6, -7)));
            Assert.IsFalse(result.Contains(new Vector2(7, -7)));
            Assert.IsFalse(result.Contains(new Vector2(8, -7)));
            Assert.IsFalse(result.Contains(new Vector2(-1, -6)));
            Assert.IsFalse(result.Contains(new Vector2(0, -6)));
            Assert.IsFalse(result.Contains(new Vector2(1, -6)));
            Assert.IsTrue(result.Contains(new Vector2(2, -6)));
            Assert.IsTrue(result.Contains(new Vector2(3, -6)));
            Assert.IsTrue(result.Contains(new Vector2(4, -6)));
            Assert.IsFalse(result.Contains(new Vector2(5, -6)));
            Assert.IsFalse(result.Contains(new Vector2(6, -6)));
            Assert.IsFalse(result.Contains(new Vector2(7, -6)));
            Assert.IsFalse(result.Contains(new Vector2(8, -6)));
            Assert.IsFalse(result.Contains(new Vector2(-1, -5)));
            Assert.IsFalse(result.Contains(new Vector2(0, -5)));
            Assert.IsTrue(result.Contains(new Vector2(1, -5)));
            Assert.IsTrue(result.Contains(new Vector2(2, -5)));
            Assert.IsTrue(result.Contains(new Vector2(3, -5)));
            Assert.IsTrue(result.Contains(new Vector2(4, -5)));
            Assert.IsTrue(result.Contains(new Vector2(5, -5)));
            Assert.IsFalse(result.Contains(new Vector2(6, -5)));
            Assert.IsFalse(result.Contains(new Vector2(7, -5)));
            Assert.IsFalse(result.Contains(new Vector2(8, -5)));
            Assert.IsFalse(result.Contains(new Vector2(-1, -4)));
            Assert.IsFalse(result.Contains(new Vector2(0, -4)));
            Assert.IsFalse(result.Contains(new Vector2(1, -4)));
            Assert.IsFalse(result.Contains(new Vector2(2, -4)));
            Assert.IsTrue(result.Contains(new Vector2(3, -4)));
            Assert.IsTrue(result.Contains(new Vector2(4, -4)));
            Assert.IsTrue(result.Contains(new Vector2(5, -4)));
            Assert.IsTrue(result.Contains(new Vector2(6, -4)));
            Assert.IsFalse(result.Contains(new Vector2(7, -4)));
            Assert.IsFalse(result.Contains(new Vector2(8, -4)));
            Assert.IsFalse(result.Contains(new Vector2(-1, -3)));
            Assert.IsFalse(result.Contains(new Vector2(0, -3)));
            Assert.IsFalse(result.Contains(new Vector2(1, -3)));
            Assert.IsFalse(result.Contains(new Vector2(2, -3)));
            Assert.IsFalse(result.Contains(new Vector2(3, -3)));
            Assert.IsTrue(result.Contains(new Vector2(4, -3)));
            Assert.IsTrue(result.Contains(new Vector2(5, -3)));
            Assert.IsTrue(result.Contains(new Vector2(6, -3)));
            Assert.IsFalse(result.Contains(new Vector2(7, -3)));
            Assert.IsFalse(result.Contains(new Vector2(8, -3)));
            Assert.IsFalse(result.Contains(new Vector2(-1, -2)));
            Assert.IsFalse(result.Contains(new Vector2(0, -2)));
            Assert.IsFalse(result.Contains(new Vector2(1, -2)));
            Assert.IsFalse(result.Contains(new Vector2(2, -2)));
            Assert.IsFalse(result.Contains(new Vector2(3, -2)));
            Assert.IsTrue(result.Contains(new Vector2(4, -2)));
            Assert.IsTrue(result.Contains(new Vector2(5, -2)));
            Assert.IsTrue(result.Contains(new Vector2(6, -2)));
            Assert.IsFalse(result.Contains(new Vector2(7, -2)));
            Assert.IsFalse(result.Contains(new Vector2(8, -2)));
            Assert.IsFalse(result.Contains(new Vector2(-1, -1)));
            Assert.IsFalse(result.Contains(new Vector2(0, -1)));
            Assert.IsFalse(result.Contains(new Vector2(1, -1)));
            Assert.IsFalse(result.Contains(new Vector2(2, -1)));
            Assert.IsFalse(result.Contains(new Vector2(3, -1)));
            Assert.IsTrue(result.Contains(new Vector2(4, -1)));
            Assert.IsTrue(result.Contains(new Vector2(5, -1)));
            Assert.IsTrue(result.Contains(new Vector2(6, -1)));
            Assert.IsTrue(result.Contains(new Vector2(7, -1)));
            Assert.IsFalse(result.Contains(new Vector2(8, -1)));
            Assert.IsFalse(result.Contains(new Vector2(-1, 0)));
            Assert.IsFalse(result.Contains(new Vector2(0, 0)));
            Assert.IsFalse(result.Contains(new Vector2(1, 0)));
            Assert.IsFalse(result.Contains(new Vector2(2, 0)));
            Assert.IsTrue(result.Contains(new Vector2(3, 0)));
            Assert.IsTrue(result.Contains(new Vector2(4, 0)));
            Assert.IsTrue(result.Contains(new Vector2(5, 0)));
            Assert.IsTrue(result.Contains(new Vector2(6, 0)));
            Assert.IsTrue(result.Contains(new Vector2(7, 0)));
            Assert.IsFalse(result.Contains(new Vector2(8, 0)));
            Assert.IsFalse(result.Contains(new Vector2(-1, 1)));
            Assert.IsFalse(result.Contains(new Vector2(0, 1)));
            Assert.IsTrue(result.Contains(new Vector2(1, 1)));
            Assert.IsTrue(result.Contains(new Vector2(2, 1)));
            Assert.IsTrue(result.Contains(new Vector2(3, 1)));
            Assert.IsTrue(result.Contains(new Vector2(4, 1)));
            Assert.IsTrue(result.Contains(new Vector2(5, 1)));
            Assert.IsTrue(result.Contains(new Vector2(6, 1)));
            Assert.IsTrue(result.Contains(new Vector2(7, 1)));
            Assert.IsFalse(result.Contains(new Vector2(8, 1)));
            Assert.IsFalse(result.Contains(new Vector2(-1, 2)));
            Assert.IsFalse(result.Contains(new Vector2(0, 2)));
            Assert.IsFalse(result.Contains(new Vector2(1, 2)));
            Assert.IsTrue(result.Contains(new Vector2(2, 2)));
            Assert.IsTrue(result.Contains(new Vector2(3, 2)));
            Assert.IsTrue(result.Contains(new Vector2(4, 2)));
            Assert.IsTrue(result.Contains(new Vector2(5, 2)));
            Assert.IsTrue(result.Contains(new Vector2(6, 2)));
            Assert.IsFalse(result.Contains(new Vector2(7, 2)));
            Assert.IsFalse(result.Contains(new Vector2(8, 2)));
            Assert.IsFalse(result.Contains(new Vector2(-1, 3)));
            Assert.IsFalse(result.Contains(new Vector2(0, 3)));
            Assert.IsFalse(result.Contains(new Vector2(1, 3)));
            Assert.IsFalse(result.Contains(new Vector2(2, 3)));
            Assert.IsTrue(result.Contains(new Vector2(3, 3)));
            Assert.IsTrue(result.Contains(new Vector2(4, 3)));
            Assert.IsTrue(result.Contains(new Vector2(5, 3)));
            Assert.IsFalse(result.Contains(new Vector2(6, 3)));
            Assert.IsFalse(result.Contains(new Vector2(7, 3)));
            Assert.IsFalse(result.Contains(new Vector2(8, 3)));
            Assert.IsFalse(result.Contains(new Vector2(-1, 4)));
            Assert.IsFalse(result.Contains(new Vector2(0, 4)));
            Assert.IsFalse(result.Contains(new Vector2(1, 4)));
            Assert.IsFalse(result.Contains(new Vector2(2, 4)));
            Assert.IsFalse(result.Contains(new Vector2(3, 4)));
            Assert.IsFalse(result.Contains(new Vector2(4, 4)));
            Assert.IsFalse(result.Contains(new Vector2(5, 4)));
            Assert.IsFalse(result.Contains(new Vector2(6, 4)));
            Assert.IsFalse(result.Contains(new Vector2(7, 4)));
            Assert.IsFalse(result.Contains(new Vector2(8, 4)));

            #endregion
        }
        [Test]
        public static void OnTargetTest()
        {
            var binding = BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Instance;
            var map1 = new Dictionary<Vector2, int> {
                { new Vector2(-2, 3), 3 },
                { new Vector2(1, 2), 3 }
            };
            var map2 = new Dictionary<Vector2, int> {
                { new Vector2(0, 0), 2 }
            };

            var range = Coverage.zero;
            range.GetType().GetField("_targetRanges", binding).SetValue(range, map1);
            range.GetType().GetField("_excludeRanges", binding).SetValue(range, map2);

            #region AssertEveryPoint

            Assert.IsFalse(range.OnTarget(new Vector2(-6, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(-5, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(-4, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(-3, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(-2, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(-1, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(0, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(1, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(2, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(3, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(4, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(5, -2)));
            Assert.IsFalse(range.OnTarget(new Vector2(-6, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(-5, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(-4, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(-3, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(-2, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(-1, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(0, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(1, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(2, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(3, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(4, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(5, -1)));
            Assert.IsFalse(range.OnTarget(new Vector2(-6, 0)));
            Assert.IsFalse(range.OnTarget(new Vector2(-5, 0)));
            Assert.IsFalse(range.OnTarget(new Vector2(-4, 0)));
            Assert.IsTrue(range.OnTarget(new Vector2(-3, 0)));
            Assert.IsFalse(range.OnTarget(new Vector2(-2, 0)));
            Assert.IsFalse(range.OnTarget(new Vector2(-1, 0)));
            Assert.IsFalse(range.OnTarget(new Vector2(0, 0)));
            Assert.IsFalse(range.OnTarget(new Vector2(1, 0)));
            Assert.IsFalse(range.OnTarget(new Vector2(2, 0)));
            Assert.IsTrue(range.OnTarget(new Vector2(3, 0)));
            Assert.IsFalse(range.OnTarget(new Vector2(4, 0)));
            Assert.IsFalse(range.OnTarget(new Vector2(5, 0)));
            Assert.IsFalse(range.OnTarget(new Vector2(-6, 1)));
            Assert.IsFalse(range.OnTarget(new Vector2(-5, 1)));
            Assert.IsTrue(range.OnTarget(new Vector2(-4, 1)));
            Assert.IsTrue(range.OnTarget(new Vector2(-3, 1)));
            Assert.IsFalse(range.OnTarget(new Vector2(-2, 1)));
            Assert.IsFalse(range.OnTarget(new Vector2(-1, 1)));
            Assert.IsFalse(range.OnTarget(new Vector2(0, 1)));
            Assert.IsFalse(range.OnTarget(new Vector2(1, 1)));
            Assert.IsFalse(range.OnTarget(new Vector2(2, 1)));
            Assert.IsTrue(range.OnTarget(new Vector2(3, 1)));
            Assert.IsTrue(range.OnTarget(new Vector2(4, 1)));
            Assert.IsFalse(range.OnTarget(new Vector2(5, 1)));
            Assert.IsFalse(range.OnTarget(new Vector2(-6, 2)));
            Assert.IsTrue(range.OnTarget(new Vector2(-5, 2)));
            Assert.IsTrue(range.OnTarget(new Vector2(-4, 2)));
            Assert.IsTrue(range.OnTarget(new Vector2(-3, 2)));
            Assert.IsTrue(range.OnTarget(new Vector2(-2, 2)));
            Assert.IsFalse(range.OnTarget(new Vector2(-1, 2)));
            Assert.IsFalse(range.OnTarget(new Vector2(0, 2)));
            Assert.IsFalse(range.OnTarget(new Vector2(1, 2)));
            Assert.IsTrue(range.OnTarget(new Vector2(2, 2)));
            Assert.IsTrue(range.OnTarget(new Vector2(3, 2)));
            Assert.IsTrue(range.OnTarget(new Vector2(4, 2)));
            Assert.IsFalse(range.OnTarget(new Vector2(5, 2)));
            Assert.IsFalse(range.OnTarget(new Vector2(-6, 3)));
            Assert.IsTrue(range.OnTarget(new Vector2(-5, 3)));
            Assert.IsTrue(range.OnTarget(new Vector2(-4, 3)));
            Assert.IsTrue(range.OnTarget(new Vector2(-3, 3)));
            Assert.IsTrue(range.OnTarget(new Vector2(-2, 3)));
            Assert.IsTrue(range.OnTarget(new Vector2(-1, 3)));
            Assert.IsTrue(range.OnTarget(new Vector2(0, 3)));
            Assert.IsTrue(range.OnTarget(new Vector2(1, 3)));
            Assert.IsTrue(range.OnTarget(new Vector2(2, 3)));
            Assert.IsTrue(range.OnTarget(new Vector2(3, 3)));
            Assert.IsTrue(range.OnTarget(new Vector2(4, 3)));
            Assert.IsFalse(range.OnTarget(new Vector2(5, 3)));
            Assert.IsFalse(range.OnTarget(new Vector2(-6, 4)));
            Assert.IsTrue(range.OnTarget(new Vector2(-5, 4)));
            Assert.IsTrue(range.OnTarget(new Vector2(-4, 4)));
            Assert.IsTrue(range.OnTarget(new Vector2(-3, 4)));
            Assert.IsTrue(range.OnTarget(new Vector2(-2, 4)));
            Assert.IsTrue(range.OnTarget(new Vector2(-1, 4)));
            Assert.IsTrue(range.OnTarget(new Vector2(0, 4)));
            Assert.IsTrue(range.OnTarget(new Vector2(1, 4)));
            Assert.IsTrue(range.OnTarget(new Vector2(2, 4)));
            Assert.IsTrue(range.OnTarget(new Vector2(3, 4)));
            Assert.IsFalse(range.OnTarget(new Vector2(4, 4)));
            Assert.IsFalse(range.OnTarget(new Vector2(5, 4)));
            Assert.IsFalse(range.OnTarget(new Vector2(-6, 5)));
            Assert.IsFalse(range.OnTarget(new Vector2(-5, 5)));
            Assert.IsTrue(range.OnTarget(new Vector2(-4, 5)));
            Assert.IsTrue(range.OnTarget(new Vector2(-3, 5)));
            Assert.IsTrue(range.OnTarget(new Vector2(-2, 5)));
            Assert.IsTrue(range.OnTarget(new Vector2(-1, 5)));
            Assert.IsTrue(range.OnTarget(new Vector2(0, 5)));
            Assert.IsTrue(range.OnTarget(new Vector2(1, 5)));
            Assert.IsTrue(range.OnTarget(new Vector2(2, 5)));
            Assert.IsFalse(range.OnTarget(new Vector2(3, 5)));
            Assert.IsFalse(range.OnTarget(new Vector2(4, 5)));
            Assert.IsFalse(range.OnTarget(new Vector2(5, 5)));
            Assert.IsFalse(range.OnTarget(new Vector2(-6, 6)));
            Assert.IsFalse(range.OnTarget(new Vector2(-5, 6)));
            Assert.IsFalse(range.OnTarget(new Vector2(-4, 6)));
            Assert.IsTrue(range.OnTarget(new Vector2(-3, 6)));
            Assert.IsTrue(range.OnTarget(new Vector2(-2, 6)));
            Assert.IsTrue(range.OnTarget(new Vector2(-1, 6)));
            Assert.IsFalse(range.OnTarget(new Vector2(0, 6)));
            Assert.IsFalse(range.OnTarget(new Vector2(1, 6)));
            Assert.IsFalse(range.OnTarget(new Vector2(2, 6)));
            Assert.IsFalse(range.OnTarget(new Vector2(3, 6)));
            Assert.IsFalse(range.OnTarget(new Vector2(4, 6)));
            Assert.IsFalse(range.OnTarget(new Vector2(5, 6)));
            Assert.IsFalse(range.OnTarget(new Vector2(-6, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(-5, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(-4, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(-3, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(-2, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(-1, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(0, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(1, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(2, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(3, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(4, 7)));
            Assert.IsFalse(range.OnTarget(new Vector2(5, 7)));

            #endregion
        }
        [Test]
        public static void OnTargetTest2()
        {
            var binding = BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Instance;
            var map1 = new Dictionary<Vector2, int> {
                { new Vector2(-2, 3), 3 },//4,0
                { new Vector2(1, 2), 3 }//3,-3
            };
            var map2 = new Dictionary<Vector2, int> {
                { new Vector2(0, 0), 2 }//1,-2
            };
            var direction = Direction.WEST;
            var center = new Vector2(1, -2);

            var range = Coverage.zero;
            range.GetType().GetField("_targetRanges", binding).SetValue(range, map1);
            range.GetType().GetField("_excludeRanges", binding).SetValue(range, map2);

            #region AssertEveryPoint

            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, -7)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, -7)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(1, -7)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(2, -7)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(3, -7)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(4, -7)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(5, -7)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(6, -7)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(7, -7)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, -7)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, -6)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, -6)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(1, -6)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(2, -6)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(3, -6)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(4, -6)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(5, -6)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(6, -6)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(7, -6)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, -6)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, -5)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, -5)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(1, -5)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(2, -5)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(3, -5)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(4, -5)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(5, -5)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(6, -5)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(7, -5)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, -5)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, -4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, -4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(1, -4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(2, -4)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(3, -4)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(4, -4)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(5, -4)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(6, -4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(7, -4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, -4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, -3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, -3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(1, -3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(2, -3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(3, -3)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(4, -3)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(5, -3)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(6, -3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(7, -3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, -3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, -2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, -2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(1, -2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(2, -2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(3, -2)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(4, -2)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(5, -2)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(6, -2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(7, -2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, -2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, -1)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, -1)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(1, -1)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(2, -1)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(3, -1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(4, -1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(5, -1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(6, -1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(7, -1)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, -1)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, 0)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, 0)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(1, 0)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(2, 0)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(3, 0)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(4, 0)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(5, 0)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(6, 0)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(7, 0)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, 0)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, 1)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, 1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(1, 1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(2, 1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(3, 1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(4, 1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(5, 1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(6, 1)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(7, 1)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, 1)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, 2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, 2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(1, 2)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(2, 2)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(3, 2)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(4, 2)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(5, 2)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(6, 2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(7, 2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, 2)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, 3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, 3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(1, 3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(2, 3)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(3, 3)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(4, 3)));
            Assert.IsTrue(range.Move(center, direction).OnTarget(new Vector2(5, 3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(6, 3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(7, 3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, 3)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(-1, 4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(0, 4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(1, 4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(2, 4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(3, 4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(4, 4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(5, 4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(6, 4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(7, 4)));
            Assert.IsFalse(range.Move(center, direction).OnTarget(new Vector2(8, 4)));

            #endregion
        }
    }
}
