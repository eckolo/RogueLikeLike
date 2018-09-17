using Assets.Src.Domain.Service;
using Assets.Src.Domain.Model.Value;
using NUnit.Framework;
using UnityEngine;

namespace TEST.Domain.Service
{
    /// <summary>
    /// 方角関係のユーティリティクラスのテスト
    /// </summary>
    public static class DirectionManagerTest
    {
        [Test]
        public static void ToVectorTest()
        {
            Assert.AreEqual(Direction.NORTH.ToVector(), Vector2.up);
            Assert.AreEqual(Direction.SOUTH.ToVector(), Vector2.down);
            Assert.AreEqual(Direction.EAST.ToVector(), Vector2.right);
            Assert.AreEqual(Direction.WEST.ToVector(), Vector2.left);
        }
        [Test]
        public static void ToVectorTest2()
        {
            Assert.AreEqual(Direction.NORTH.ToVector(), Vector2.up);
            Assert.AreEqual(Direction.SOUTH.ToVector(), Vector2.down);
            Assert.AreEqual(Direction.EAST.ToVector(), Vector2.right);
            Assert.AreEqual(Direction.WEST.ToVector(), Vector2.left);
            Assert.AreEqual(((Direction?)null).ToVector(), Vector2.zero);
        }

        [Test]
        public static void ToDirectionTest()
        {
            Assert.AreEqual(Vector2.up.ToDirection(), Direction.NORTH);
            Assert.AreEqual(Vector2.down.ToDirection(), Direction.SOUTH);
            Assert.AreEqual(Vector2.right.ToDirection(), Direction.EAST);
            Assert.AreEqual(Vector2.left.ToDirection(), Direction.WEST);
        }
        [Test]
        public static void ToDirectionTest2()
        {
            Assert.AreEqual(new Vector2(0, 2).ToDirection(), Direction.NORTH);
            Assert.AreEqual(new Vector2(0, -4).ToDirection(), Direction.SOUTH);
            Assert.AreEqual(new Vector2(6, 0).ToDirection(), Direction.EAST);
            Assert.AreEqual(new Vector2(-8, 0).ToDirection(), Direction.WEST);
        }
        [Test]
        public static void ToDirectionTest3()
        {
            try
            {
                new Vector2(1, 2).ToDirection();
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [Test]
        public static void RotateTest()
        {
            Assert.AreEqual(Direction.NORTH.Rotate(Direction.NORTH), Direction.NORTH);
            Assert.AreEqual(Direction.NORTH.Rotate(Direction.SOUTH), Direction.SOUTH);
            Assert.AreEqual(Direction.NORTH.Rotate(Direction.EAST), Direction.WEST);
            Assert.AreEqual(Direction.NORTH.Rotate(Direction.WEST), Direction.EAST);
        }
        [Test]
        public static void RotateTest2()
        {
            Assert.AreEqual(Direction.SOUTH.Rotate(Direction.NORTH), Direction.SOUTH);
            Assert.AreEqual(Direction.SOUTH.Rotate(Direction.SOUTH), Direction.NORTH);
            Assert.AreEqual(Direction.SOUTH.Rotate(Direction.EAST), Direction.EAST);
            Assert.AreEqual(Direction.SOUTH.Rotate(Direction.WEST), Direction.WEST);
        }
        [Test]
        public static void RotateTest3()
        {
            Assert.AreEqual(Direction.EAST.Rotate(Direction.NORTH), Direction.EAST);
            Assert.AreEqual(Direction.EAST.Rotate(Direction.SOUTH), Direction.WEST);
            Assert.AreEqual(Direction.EAST.Rotate(Direction.EAST), Direction.NORTH);
            Assert.AreEqual(Direction.EAST.Rotate(Direction.WEST), Direction.SOUTH);
        }
        [Test]
        public static void RotateTest4()
        {
            Assert.AreEqual(Direction.WEST.Rotate(Direction.NORTH), Direction.WEST);
            Assert.AreEqual(Direction.WEST.Rotate(Direction.SOUTH), Direction.EAST);
            Assert.AreEqual(Direction.WEST.Rotate(Direction.EAST), Direction.SOUTH);
            Assert.AreEqual(Direction.WEST.Rotate(Direction.WEST), Direction.NORTH);
        }

        [Test]
        public static void RotateTest5()
        {
            var vector = new Vector2(3, 5);

            Assert.AreEqual(new Vector2(3, 5), vector.Rotate(Direction.NORTH));
            Assert.AreEqual(new Vector2(-3, -5), vector.Rotate(Direction.SOUTH));
            Assert.AreEqual(new Vector2(-5, 3), vector.Rotate(Direction.EAST));
            Assert.AreEqual(new Vector2(5, -3), vector.Rotate(Direction.WEST));
        }
        [Test]
        public static void RotateTest6()
        {
            var vector1 = new Vector2(3, 5);
            var vector2 = new Vector2(-1, 2);

            Assert.AreEqual(new Vector2(3, 5), vector1.Rotate(Direction.NORTH, vector2));
            Assert.AreEqual(new Vector2(-5, -1), vector1.Rotate(Direction.SOUTH, vector2));
            Assert.AreEqual(new Vector2(-4, 6), vector1.Rotate(Direction.EAST, vector2));
            Assert.AreEqual(new Vector2(2, -2), vector1.Rotate(Direction.WEST, vector2));
        }
    }
}
