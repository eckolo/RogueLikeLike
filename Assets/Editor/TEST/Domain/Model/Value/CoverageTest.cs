using Assets.Src.Domain.Model.Value;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Assets.Editor.TEST.Domain.Model.Value
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

            result.Contains(new Vector2(-6, -2)).IsFalse();
            result.Contains(new Vector2(-5, -2)).IsFalse();
            result.Contains(new Vector2(-4, -2)).IsFalse();
            result.Contains(new Vector2(-3, -2)).IsFalse();
            result.Contains(new Vector2(-2, -2)).IsFalse();
            result.Contains(new Vector2(-1, -2)).IsFalse();
            result.Contains(new Vector2(0, -2)).IsFalse();
            result.Contains(new Vector2(1, -2)).IsFalse();
            result.Contains(new Vector2(2, -2)).IsFalse();
            result.Contains(new Vector2(3, -2)).IsFalse();
            result.Contains(new Vector2(4, -2)).IsFalse();
            result.Contains(new Vector2(5, -2)).IsFalse();
            result.Contains(new Vector2(-6, -1)).IsFalse();
            result.Contains(new Vector2(-5, -1)).IsFalse();
            result.Contains(new Vector2(-4, -1)).IsFalse();
            result.Contains(new Vector2(-3, -1)).IsFalse();
            result.Contains(new Vector2(-2, -1)).IsFalse();
            result.Contains(new Vector2(-1, -1)).IsFalse();
            result.Contains(new Vector2(0, -1)).IsFalse();
            result.Contains(new Vector2(1, -1)).IsFalse();
            result.Contains(new Vector2(2, -1)).IsFalse();
            result.Contains(new Vector2(3, -1)).IsFalse();
            result.Contains(new Vector2(4, -1)).IsFalse();
            result.Contains(new Vector2(5, -1)).IsFalse();
            result.Contains(new Vector2(-6, 0)).IsFalse();
            result.Contains(new Vector2(-5, 0)).IsFalse();
            result.Contains(new Vector2(-4, 0)).IsFalse();
            result.Contains(new Vector2(-3, 0)).IsTrue();
            result.Contains(new Vector2(-2, 0)).IsFalse();
            result.Contains(new Vector2(-1, 0)).IsFalse();
            result.Contains(new Vector2(0, 0)).IsFalse();
            result.Contains(new Vector2(1, 0)).IsFalse();
            result.Contains(new Vector2(2, 0)).IsFalse();
            result.Contains(new Vector2(3, 0)).IsTrue();
            result.Contains(new Vector2(4, 0)).IsFalse();
            result.Contains(new Vector2(5, 0)).IsFalse();
            result.Contains(new Vector2(-6, 1)).IsFalse();
            result.Contains(new Vector2(-5, 1)).IsFalse();
            result.Contains(new Vector2(-4, 1)).IsTrue();
            result.Contains(new Vector2(-3, 1)).IsTrue();
            result.Contains(new Vector2(-2, 1)).IsFalse();
            result.Contains(new Vector2(-1, 1)).IsFalse();
            result.Contains(new Vector2(0, 1)).IsFalse();
            result.Contains(new Vector2(1, 1)).IsFalse();
            result.Contains(new Vector2(2, 1)).IsFalse();
            result.Contains(new Vector2(3, 1)).IsTrue();
            result.Contains(new Vector2(4, 1)).IsTrue();
            result.Contains(new Vector2(5, 1)).IsFalse();
            result.Contains(new Vector2(-6, 2)).IsFalse();
            result.Contains(new Vector2(-5, 2)).IsTrue();
            result.Contains(new Vector2(-4, 2)).IsTrue();
            result.Contains(new Vector2(-3, 2)).IsTrue();
            result.Contains(new Vector2(-2, 2)).IsTrue();
            result.Contains(new Vector2(-1, 2)).IsFalse();
            result.Contains(new Vector2(0, 2)).IsFalse();
            result.Contains(new Vector2(1, 2)).IsFalse();
            result.Contains(new Vector2(2, 2)).IsTrue();
            result.Contains(new Vector2(3, 2)).IsTrue();
            result.Contains(new Vector2(4, 2)).IsTrue();
            result.Contains(new Vector2(5, 2)).IsFalse();
            result.Contains(new Vector2(-6, 3)).IsFalse();
            result.Contains(new Vector2(-5, 3)).IsTrue();
            result.Contains(new Vector2(-4, 3)).IsTrue();
            result.Contains(new Vector2(-3, 3)).IsTrue();
            result.Contains(new Vector2(-2, 3)).IsTrue();
            result.Contains(new Vector2(-1, 3)).IsTrue();
            result.Contains(new Vector2(0, 3)).IsTrue();
            result.Contains(new Vector2(1, 3)).IsTrue();
            result.Contains(new Vector2(2, 3)).IsTrue();
            result.Contains(new Vector2(3, 3)).IsTrue();
            result.Contains(new Vector2(4, 3)).IsTrue();
            result.Contains(new Vector2(5, 3)).IsFalse();
            result.Contains(new Vector2(-6, 4)).IsFalse();
            result.Contains(new Vector2(-5, 4)).IsTrue();
            result.Contains(new Vector2(-4, 4)).IsTrue();
            result.Contains(new Vector2(-3, 4)).IsTrue();
            result.Contains(new Vector2(-2, 4)).IsTrue();
            result.Contains(new Vector2(-1, 4)).IsTrue();
            result.Contains(new Vector2(0, 4)).IsTrue();
            result.Contains(new Vector2(1, 4)).IsTrue();
            result.Contains(new Vector2(2, 4)).IsTrue();
            result.Contains(new Vector2(3, 4)).IsTrue();
            result.Contains(new Vector2(4, 4)).IsFalse();
            result.Contains(new Vector2(5, 4)).IsFalse();
            result.Contains(new Vector2(-6, 5)).IsFalse();
            result.Contains(new Vector2(-5, 5)).IsFalse();
            result.Contains(new Vector2(-4, 5)).IsTrue();
            result.Contains(new Vector2(-3, 5)).IsTrue();
            result.Contains(new Vector2(-2, 5)).IsTrue();
            result.Contains(new Vector2(-1, 5)).IsTrue();
            result.Contains(new Vector2(0, 5)).IsTrue();
            result.Contains(new Vector2(1, 5)).IsTrue();
            result.Contains(new Vector2(2, 5)).IsTrue();
            result.Contains(new Vector2(3, 5)).IsFalse();
            result.Contains(new Vector2(4, 5)).IsFalse();
            result.Contains(new Vector2(5, 5)).IsFalse();
            result.Contains(new Vector2(-6, 6)).IsFalse();
            result.Contains(new Vector2(-5, 6)).IsFalse();
            result.Contains(new Vector2(-4, 6)).IsFalse();
            result.Contains(new Vector2(-3, 6)).IsTrue();
            result.Contains(new Vector2(-2, 6)).IsTrue();
            result.Contains(new Vector2(-1, 6)).IsTrue();
            result.Contains(new Vector2(0, 6)).IsFalse();
            result.Contains(new Vector2(1, 6)).IsFalse();
            result.Contains(new Vector2(2, 6)).IsFalse();
            result.Contains(new Vector2(3, 6)).IsFalse();
            result.Contains(new Vector2(4, 6)).IsFalse();
            result.Contains(new Vector2(5, 6)).IsFalse();
            result.Contains(new Vector2(-6, 7)).IsFalse();
            result.Contains(new Vector2(-5, 7)).IsFalse();
            result.Contains(new Vector2(-4, 7)).IsFalse();
            result.Contains(new Vector2(-3, 7)).IsFalse();
            result.Contains(new Vector2(-2, 7)).IsFalse();
            result.Contains(new Vector2(-1, 7)).IsFalse();
            result.Contains(new Vector2(0, 7)).IsFalse();
            result.Contains(new Vector2(1, 7)).IsFalse();
            result.Contains(new Vector2(2, 7)).IsFalse();
            result.Contains(new Vector2(3, 7)).IsFalse();
            result.Contains(new Vector2(4, 7)).IsFalse();
            result.Contains(new Vector2(5, 7)).IsFalse();

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

            result.Contains(new Vector2(-1, -7)).IsFalse();
            result.Contains(new Vector2(0, -7)).IsFalse();
            result.Contains(new Vector2(1, -7)).IsFalse();
            result.Contains(new Vector2(2, -7)).IsFalse();
            result.Contains(new Vector2(3, -7)).IsFalse();
            result.Contains(new Vector2(4, -7)).IsFalse();
            result.Contains(new Vector2(5, -7)).IsFalse();
            result.Contains(new Vector2(6, -7)).IsFalse();
            result.Contains(new Vector2(7, -7)).IsFalse();
            result.Contains(new Vector2(8, -7)).IsFalse();
            result.Contains(new Vector2(-1, -6)).IsFalse();
            result.Contains(new Vector2(0, -6)).IsFalse();
            result.Contains(new Vector2(1, -6)).IsFalse();
            result.Contains(new Vector2(2, -6)).IsTrue();
            result.Contains(new Vector2(3, -6)).IsTrue();
            result.Contains(new Vector2(4, -6)).IsTrue();
            result.Contains(new Vector2(5, -6)).IsFalse();
            result.Contains(new Vector2(6, -6)).IsFalse();
            result.Contains(new Vector2(7, -6)).IsFalse();
            result.Contains(new Vector2(8, -6)).IsFalse();
            result.Contains(new Vector2(-1, -5)).IsFalse();
            result.Contains(new Vector2(0, -5)).IsFalse();
            result.Contains(new Vector2(1, -5)).IsTrue();
            result.Contains(new Vector2(2, -5)).IsTrue();
            result.Contains(new Vector2(3, -5)).IsTrue();
            result.Contains(new Vector2(4, -5)).IsTrue();
            result.Contains(new Vector2(5, -5)).IsTrue();
            result.Contains(new Vector2(6, -5)).IsFalse();
            result.Contains(new Vector2(7, -5)).IsFalse();
            result.Contains(new Vector2(8, -5)).IsFalse();
            result.Contains(new Vector2(-1, -4)).IsFalse();
            result.Contains(new Vector2(0, -4)).IsFalse();
            result.Contains(new Vector2(1, -4)).IsFalse();
            result.Contains(new Vector2(2, -4)).IsFalse();
            result.Contains(new Vector2(3, -4)).IsTrue();
            result.Contains(new Vector2(4, -4)).IsTrue();
            result.Contains(new Vector2(5, -4)).IsTrue();
            result.Contains(new Vector2(6, -4)).IsTrue();
            result.Contains(new Vector2(7, -4)).IsFalse();
            result.Contains(new Vector2(8, -4)).IsFalse();
            result.Contains(new Vector2(-1, -3)).IsFalse();
            result.Contains(new Vector2(0, -3)).IsFalse();
            result.Contains(new Vector2(1, -3)).IsFalse();
            result.Contains(new Vector2(2, -3)).IsFalse();
            result.Contains(new Vector2(3, -3)).IsFalse();
            result.Contains(new Vector2(4, -3)).IsTrue();
            result.Contains(new Vector2(5, -3)).IsTrue();
            result.Contains(new Vector2(6, -3)).IsTrue();
            result.Contains(new Vector2(7, -3)).IsFalse();
            result.Contains(new Vector2(8, -3)).IsFalse();
            result.Contains(new Vector2(-1, -2)).IsFalse();
            result.Contains(new Vector2(0, -2)).IsFalse();
            result.Contains(new Vector2(1, -2)).IsFalse();
            result.Contains(new Vector2(2, -2)).IsFalse();
            result.Contains(new Vector2(3, -2)).IsFalse();
            result.Contains(new Vector2(4, -2)).IsTrue();
            result.Contains(new Vector2(5, -2)).IsTrue();
            result.Contains(new Vector2(6, -2)).IsTrue();
            result.Contains(new Vector2(7, -2)).IsFalse();
            result.Contains(new Vector2(8, -2)).IsFalse();
            result.Contains(new Vector2(-1, -1)).IsFalse();
            result.Contains(new Vector2(0, -1)).IsFalse();
            result.Contains(new Vector2(1, -1)).IsFalse();
            result.Contains(new Vector2(2, -1)).IsFalse();
            result.Contains(new Vector2(3, -1)).IsFalse();
            result.Contains(new Vector2(4, -1)).IsTrue();
            result.Contains(new Vector2(5, -1)).IsTrue();
            result.Contains(new Vector2(6, -1)).IsTrue();
            result.Contains(new Vector2(7, -1)).IsTrue();
            result.Contains(new Vector2(8, -1)).IsFalse();
            result.Contains(new Vector2(-1, 0)).IsFalse();
            result.Contains(new Vector2(0, 0)).IsFalse();
            result.Contains(new Vector2(1, 0)).IsFalse();
            result.Contains(new Vector2(2, 0)).IsFalse();
            result.Contains(new Vector2(3, 0)).IsTrue();
            result.Contains(new Vector2(4, 0)).IsTrue();
            result.Contains(new Vector2(5, 0)).IsTrue();
            result.Contains(new Vector2(6, 0)).IsTrue();
            result.Contains(new Vector2(7, 0)).IsTrue();
            result.Contains(new Vector2(8, 0)).IsFalse();
            result.Contains(new Vector2(-1, 1)).IsFalse();
            result.Contains(new Vector2(0, 1)).IsFalse();
            result.Contains(new Vector2(1, 1)).IsTrue();
            result.Contains(new Vector2(2, 1)).IsTrue();
            result.Contains(new Vector2(3, 1)).IsTrue();
            result.Contains(new Vector2(4, 1)).IsTrue();
            result.Contains(new Vector2(5, 1)).IsTrue();
            result.Contains(new Vector2(6, 1)).IsTrue();
            result.Contains(new Vector2(7, 1)).IsTrue();
            result.Contains(new Vector2(8, 1)).IsFalse();
            result.Contains(new Vector2(-1, 2)).IsFalse();
            result.Contains(new Vector2(0, 2)).IsFalse();
            result.Contains(new Vector2(1, 2)).IsFalse();
            result.Contains(new Vector2(2, 2)).IsTrue();
            result.Contains(new Vector2(3, 2)).IsTrue();
            result.Contains(new Vector2(4, 2)).IsTrue();
            result.Contains(new Vector2(5, 2)).IsTrue();
            result.Contains(new Vector2(6, 2)).IsTrue();
            result.Contains(new Vector2(7, 2)).IsFalse();
            result.Contains(new Vector2(8, 2)).IsFalse();
            result.Contains(new Vector2(-1, 3)).IsFalse();
            result.Contains(new Vector2(0, 3)).IsFalse();
            result.Contains(new Vector2(1, 3)).IsFalse();
            result.Contains(new Vector2(2, 3)).IsFalse();
            result.Contains(new Vector2(3, 3)).IsTrue();
            result.Contains(new Vector2(4, 3)).IsTrue();
            result.Contains(new Vector2(5, 3)).IsTrue();
            result.Contains(new Vector2(6, 3)).IsFalse();
            result.Contains(new Vector2(7, 3)).IsFalse();
            result.Contains(new Vector2(8, 3)).IsFalse();
            result.Contains(new Vector2(-1, 4)).IsFalse();
            result.Contains(new Vector2(0, 4)).IsFalse();
            result.Contains(new Vector2(1, 4)).IsFalse();
            result.Contains(new Vector2(2, 4)).IsFalse();
            result.Contains(new Vector2(3, 4)).IsFalse();
            result.Contains(new Vector2(4, 4)).IsFalse();
            result.Contains(new Vector2(5, 4)).IsFalse();
            result.Contains(new Vector2(6, 4)).IsFalse();
            result.Contains(new Vector2(7, 4)).IsFalse();
            result.Contains(new Vector2(8, 4)).IsFalse();

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

            range.OnTarget(new Vector2(-6, -2)).IsFalse();
            range.OnTarget(new Vector2(-5, -2)).IsFalse();
            range.OnTarget(new Vector2(-4, -2)).IsFalse();
            range.OnTarget(new Vector2(-3, -2)).IsFalse();
            range.OnTarget(new Vector2(-2, -2)).IsFalse();
            range.OnTarget(new Vector2(-1, -2)).IsFalse();
            range.OnTarget(new Vector2(0, -2)).IsFalse();
            range.OnTarget(new Vector2(1, -2)).IsFalse();
            range.OnTarget(new Vector2(2, -2)).IsFalse();
            range.OnTarget(new Vector2(3, -2)).IsFalse();
            range.OnTarget(new Vector2(4, -2)).IsFalse();
            range.OnTarget(new Vector2(5, -2)).IsFalse();
            range.OnTarget(new Vector2(-6, -1)).IsFalse();
            range.OnTarget(new Vector2(-5, -1)).IsFalse();
            range.OnTarget(new Vector2(-4, -1)).IsFalse();
            range.OnTarget(new Vector2(-3, -1)).IsFalse();
            range.OnTarget(new Vector2(-2, -1)).IsFalse();
            range.OnTarget(new Vector2(-1, -1)).IsFalse();
            range.OnTarget(new Vector2(0, -1)).IsFalse();
            range.OnTarget(new Vector2(1, -1)).IsFalse();
            range.OnTarget(new Vector2(2, -1)).IsFalse();
            range.OnTarget(new Vector2(3, -1)).IsFalse();
            range.OnTarget(new Vector2(4, -1)).IsFalse();
            range.OnTarget(new Vector2(5, -1)).IsFalse();
            range.OnTarget(new Vector2(-6, 0)).IsFalse();
            range.OnTarget(new Vector2(-5, 0)).IsFalse();
            range.OnTarget(new Vector2(-4, 0)).IsFalse();
            range.OnTarget(new Vector2(-3, 0)).IsTrue();
            range.OnTarget(new Vector2(-2, 0)).IsFalse();
            range.OnTarget(new Vector2(-1, 0)).IsFalse();
            range.OnTarget(new Vector2(0, 0)).IsFalse();
            range.OnTarget(new Vector2(1, 0)).IsFalse();
            range.OnTarget(new Vector2(2, 0)).IsFalse();
            range.OnTarget(new Vector2(3, 0)).IsTrue();
            range.OnTarget(new Vector2(4, 0)).IsFalse();
            range.OnTarget(new Vector2(5, 0)).IsFalse();
            range.OnTarget(new Vector2(-6, 1)).IsFalse();
            range.OnTarget(new Vector2(-5, 1)).IsFalse();
            range.OnTarget(new Vector2(-4, 1)).IsTrue();
            range.OnTarget(new Vector2(-3, 1)).IsTrue();
            range.OnTarget(new Vector2(-2, 1)).IsFalse();
            range.OnTarget(new Vector2(-1, 1)).IsFalse();
            range.OnTarget(new Vector2(0, 1)).IsFalse();
            range.OnTarget(new Vector2(1, 1)).IsFalse();
            range.OnTarget(new Vector2(2, 1)).IsFalse();
            range.OnTarget(new Vector2(3, 1)).IsTrue();
            range.OnTarget(new Vector2(4, 1)).IsTrue();
            range.OnTarget(new Vector2(5, 1)).IsFalse();
            range.OnTarget(new Vector2(-6, 2)).IsFalse();
            range.OnTarget(new Vector2(-5, 2)).IsTrue();
            range.OnTarget(new Vector2(-4, 2)).IsTrue();
            range.OnTarget(new Vector2(-3, 2)).IsTrue();
            range.OnTarget(new Vector2(-2, 2)).IsTrue();
            range.OnTarget(new Vector2(-1, 2)).IsFalse();
            range.OnTarget(new Vector2(0, 2)).IsFalse();
            range.OnTarget(new Vector2(1, 2)).IsFalse();
            range.OnTarget(new Vector2(2, 2)).IsTrue();
            range.OnTarget(new Vector2(3, 2)).IsTrue();
            range.OnTarget(new Vector2(4, 2)).IsTrue();
            range.OnTarget(new Vector2(5, 2)).IsFalse();
            range.OnTarget(new Vector2(-6, 3)).IsFalse();
            range.OnTarget(new Vector2(-5, 3)).IsTrue();
            range.OnTarget(new Vector2(-4, 3)).IsTrue();
            range.OnTarget(new Vector2(-3, 3)).IsTrue();
            range.OnTarget(new Vector2(-2, 3)).IsTrue();
            range.OnTarget(new Vector2(-1, 3)).IsTrue();
            range.OnTarget(new Vector2(0, 3)).IsTrue();
            range.OnTarget(new Vector2(1, 3)).IsTrue();
            range.OnTarget(new Vector2(2, 3)).IsTrue();
            range.OnTarget(new Vector2(3, 3)).IsTrue();
            range.OnTarget(new Vector2(4, 3)).IsTrue();
            range.OnTarget(new Vector2(5, 3)).IsFalse();
            range.OnTarget(new Vector2(-6, 4)).IsFalse();
            range.OnTarget(new Vector2(-5, 4)).IsTrue();
            range.OnTarget(new Vector2(-4, 4)).IsTrue();
            range.OnTarget(new Vector2(-3, 4)).IsTrue();
            range.OnTarget(new Vector2(-2, 4)).IsTrue();
            range.OnTarget(new Vector2(-1, 4)).IsTrue();
            range.OnTarget(new Vector2(0, 4)).IsTrue();
            range.OnTarget(new Vector2(1, 4)).IsTrue();
            range.OnTarget(new Vector2(2, 4)).IsTrue();
            range.OnTarget(new Vector2(3, 4)).IsTrue();
            range.OnTarget(new Vector2(4, 4)).IsFalse();
            range.OnTarget(new Vector2(5, 4)).IsFalse();
            range.OnTarget(new Vector2(-6, 5)).IsFalse();
            range.OnTarget(new Vector2(-5, 5)).IsFalse();
            range.OnTarget(new Vector2(-4, 5)).IsTrue();
            range.OnTarget(new Vector2(-3, 5)).IsTrue();
            range.OnTarget(new Vector2(-2, 5)).IsTrue();
            range.OnTarget(new Vector2(-1, 5)).IsTrue();
            range.OnTarget(new Vector2(0, 5)).IsTrue();
            range.OnTarget(new Vector2(1, 5)).IsTrue();
            range.OnTarget(new Vector2(2, 5)).IsTrue();
            range.OnTarget(new Vector2(3, 5)).IsFalse();
            range.OnTarget(new Vector2(4, 5)).IsFalse();
            range.OnTarget(new Vector2(5, 5)).IsFalse();
            range.OnTarget(new Vector2(-6, 6)).IsFalse();
            range.OnTarget(new Vector2(-5, 6)).IsFalse();
            range.OnTarget(new Vector2(-4, 6)).IsFalse();
            range.OnTarget(new Vector2(-3, 6)).IsTrue();
            range.OnTarget(new Vector2(-2, 6)).IsTrue();
            range.OnTarget(new Vector2(-1, 6)).IsTrue();
            range.OnTarget(new Vector2(0, 6)).IsFalse();
            range.OnTarget(new Vector2(1, 6)).IsFalse();
            range.OnTarget(new Vector2(2, 6)).IsFalse();
            range.OnTarget(new Vector2(3, 6)).IsFalse();
            range.OnTarget(new Vector2(4, 6)).IsFalse();
            range.OnTarget(new Vector2(5, 6)).IsFalse();
            range.OnTarget(new Vector2(-6, 7)).IsFalse();
            range.OnTarget(new Vector2(-5, 7)).IsFalse();
            range.OnTarget(new Vector2(-4, 7)).IsFalse();
            range.OnTarget(new Vector2(-3, 7)).IsFalse();
            range.OnTarget(new Vector2(-2, 7)).IsFalse();
            range.OnTarget(new Vector2(-1, 7)).IsFalse();
            range.OnTarget(new Vector2(0, 7)).IsFalse();
            range.OnTarget(new Vector2(1, 7)).IsFalse();
            range.OnTarget(new Vector2(2, 7)).IsFalse();
            range.OnTarget(new Vector2(3, 7)).IsFalse();
            range.OnTarget(new Vector2(4, 7)).IsFalse();
            range.OnTarget(new Vector2(5, 7)).IsFalse();

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

            range.Move(center, direction).OnTarget(new Vector2(-1, -7)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, -7)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, -7)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(2, -7)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(3, -7)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(4, -7)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(5, -7)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(6, -7)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(7, -7)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(8, -7)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, -6)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, -6)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, -6)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(2, -6)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(3, -6)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(4, -6)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(5, -6)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(6, -6)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(7, -6)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(8, -6)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, -5)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, -5)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, -5)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(2, -5)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(3, -5)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(4, -5)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(5, -5)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(6, -5)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(7, -5)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(8, -5)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, -4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, -4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, -4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(2, -4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(3, -4)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(4, -4)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(5, -4)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(6, -4)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(7, -4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(8, -4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, -3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, -3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, -3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(2, -3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(3, -3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(4, -3)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(5, -3)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(6, -3)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(7, -3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(8, -3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, -2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, -2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, -2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(2, -2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(3, -2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(4, -2)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(5, -2)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(6, -2)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(7, -2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(8, -2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, -1)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, -1)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, -1)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(2, -1)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(3, -1)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(4, -1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(5, -1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(6, -1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(7, -1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(8, -1)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, 0)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, 0)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, 0)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(2, 0)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(3, 0)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(4, 0)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(5, 0)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(6, 0)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(7, 0)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(8, 0)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, 1)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, 1)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, 1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(2, 1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(3, 1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(4, 1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(5, 1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(6, 1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(7, 1)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(8, 1)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, 2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, 2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, 2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(2, 2)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(3, 2)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(4, 2)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(5, 2)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(6, 2)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(7, 2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(8, 2)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, 3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, 3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, 3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(2, 3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(3, 3)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(4, 3)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(5, 3)).IsTrue();
            range.Move(center, direction).OnTarget(new Vector2(6, 3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(7, 3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(8, 3)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(-1, 4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(0, 4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(1, 4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(2, 4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(3, 4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(4, 4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(5, 4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(6, 4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(7, 4)).IsFalse();
            range.Move(center, direction).OnTarget(new Vector2(8, 4)).IsFalse();

            #endregion
        }
    }
}
