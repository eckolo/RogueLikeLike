using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Service;
using NUnit.Framework;
using System;
using UnityEngine;

namespace Assets.Editor.TEST.Domain.Service
{
    /// <summary>
    /// 方角関係のユーティリティクラスのテスト
    /// </summary>
    public static class DirectionManagerTest
    {
        [Test]
        public static void ToVectorTest()
        {
            Direction.NORTH.ToVector().Is(Vector2.up);
            Direction.SOUTH.ToVector().Is(Vector2.down);
            Direction.EAST.ToVector().Is(Vector2.right);
            Direction.WEST.ToVector().Is(Vector2.left);
        }
        [Test]
        public static void ToVectorTest2()
        {
            Direction.NORTH.ToVector().Is(Vector2.up);
            Direction.SOUTH.ToVector().Is(Vector2.down);
            Direction.EAST.ToVector().Is(Vector2.right);
            Direction.WEST.ToVector().Is(Vector2.left);
            ((Direction?)null).ToVector().Is(Vector2.zero);
        }

        [Test]
        public static void ToDirectionTest()
        {
            Vector2.up.ToDirection().Is(Direction.NORTH);
            Vector2.down.ToDirection().Is(Direction.SOUTH);
            Vector2.right.ToDirection().Is(Direction.EAST);
            Vector2.left.ToDirection().Is(Direction.WEST);
        }
        [Test]
        public static void ToDirectionTest2()
        {
            new Vector2(0, 2).ToDirection().Is(Direction.NORTH);
            new Vector2(0, -4).ToDirection().Is(Direction.SOUTH);
            new Vector2(6, 0).ToDirection().Is(Direction.EAST);
            new Vector2(-8, 0).ToDirection().Is(Direction.WEST);
        }
        [Test]
        public static void ToDirectionTest3()
        {
            Assert.Throws<IndexOutOfRangeException>(() => new Vector2(1, 2).ToDirection());
        }

        [Test]
        public static void RotateTest()
        {
            Direction.NORTH.Rotate(Direction.NORTH).Is(Direction.NORTH);
            Direction.NORTH.Rotate(Direction.SOUTH).Is(Direction.SOUTH);
            Direction.NORTH.Rotate(Direction.EAST).Is(Direction.WEST);
            Direction.NORTH.Rotate(Direction.WEST).Is(Direction.EAST);
        }
        [Test]
        public static void RotateTest2()
        {
            Direction.SOUTH.Rotate(Direction.NORTH).Is(Direction.SOUTH);
            Direction.SOUTH.Rotate(Direction.SOUTH).Is(Direction.NORTH);
            Direction.SOUTH.Rotate(Direction.EAST).Is(Direction.EAST);
            Direction.SOUTH.Rotate(Direction.WEST).Is(Direction.WEST);
        }
        [Test]
        public static void RotateTest3()
        {
            Direction.EAST.Rotate(Direction.NORTH).Is(Direction.EAST);
            Direction.EAST.Rotate(Direction.SOUTH).Is(Direction.WEST);
            Direction.EAST.Rotate(Direction.EAST).Is(Direction.NORTH);
            Direction.EAST.Rotate(Direction.WEST).Is(Direction.SOUTH);
        }
        [Test]
        public static void RotateTest4()
        {
            Direction.WEST.Rotate(Direction.NORTH).Is(Direction.WEST);
            Direction.WEST.Rotate(Direction.SOUTH).Is(Direction.EAST);
            Direction.WEST.Rotate(Direction.EAST).Is(Direction.SOUTH);
            Direction.WEST.Rotate(Direction.WEST).Is(Direction.NORTH);
        }

        [Test]
        public static void RotateTest5()
        {
            var vector = new Vector2(3, 5);

            vector.Rotate(Direction.NORTH).Is(new Vector2(3, 5));
            vector.Rotate(Direction.SOUTH).Is(new Vector2(-3, -5));
            vector.Rotate(Direction.EAST).Is(new Vector2(-5, 3));
            vector.Rotate(Direction.WEST).Is(new Vector2(5, -3));
        }
        [Test]
        public static void RotateTest6()
        {
            var vector1 = new Vector2(3, 5);
            var vector2 = new Vector2(-1, 2);

            vector1.Rotate(Direction.NORTH, vector2).Is(new Vector2(3, 5));
            vector1.Rotate(Direction.SOUTH, vector2).Is(new Vector2(-5, -1));
            vector1.Rotate(Direction.EAST, vector2).Is(new Vector2(-4, 6));
            vector1.Rotate(Direction.WEST, vector2).Is(new Vector2(2, -2));
        }
    }
}
