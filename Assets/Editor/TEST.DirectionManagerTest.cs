using Assets.Src.Domains.Service;
using Assets.Src.Domains.Models.Value;
using NUnit.Framework;
using UnityEngine;

public static partial class TEST
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
        public static void RotationTest()
        {
            Assert.AreEqual(Direction.NORTH.Rotation(Direction.NORTH), Direction.NORTH);
            Assert.AreEqual(Direction.NORTH.Rotation(Direction.SOUTH), Direction.SOUTH);
            Assert.AreEqual(Direction.NORTH.Rotation(Direction.EAST), Direction.EAST);
            Assert.AreEqual(Direction.NORTH.Rotation(Direction.WEST), Direction.WEST);
        }
        [Test]
        public static void RotationTest2()
        {
            Assert.AreEqual(Direction.SOUTH.Rotation(Direction.NORTH), Direction.SOUTH);
            Assert.AreEqual(Direction.SOUTH.Rotation(Direction.SOUTH), Direction.NORTH);
            Assert.AreEqual(Direction.SOUTH.Rotation(Direction.EAST), Direction.WEST);
            Assert.AreEqual(Direction.SOUTH.Rotation(Direction.WEST), Direction.EAST);
        }
        [Test]
        public static void RotationTest3()
        {
            Assert.AreEqual(Direction.EAST.Rotation(Direction.NORTH), Direction.EAST);
            Assert.AreEqual(Direction.EAST.Rotation(Direction.SOUTH), Direction.WEST);
            Assert.AreEqual(Direction.EAST.Rotation(Direction.EAST), Direction.SOUTH);
            Assert.AreEqual(Direction.EAST.Rotation(Direction.WEST), Direction.NORTH);
        }
        [Test]
        public static void RotationTest4()
        {
            Assert.AreEqual(Direction.WEST.Rotation(Direction.NORTH), Direction.WEST);
            Assert.AreEqual(Direction.WEST.Rotation(Direction.SOUTH), Direction.EAST);
            Assert.AreEqual(Direction.WEST.Rotation(Direction.EAST), Direction.NORTH);
            Assert.AreEqual(Direction.WEST.Rotation(Direction.WEST), Direction.SOUTH);
        }

        [Test]
        public static void RotationTest5()
        {
            var vector = new Vector2(3, 5);

            Assert.AreEqual(new Vector2(3, 5), vector.Rotation(Direction.NORTH));
            Assert.AreEqual(new Vector2(-3, -5), vector.Rotation(Direction.SOUTH));
            Assert.AreEqual(new Vector2(5, -3), vector.Rotation(Direction.EAST));
            Assert.AreEqual(new Vector2(-5, 3), vector.Rotation(Direction.WEST));
        }
        [Test]
        public static void RotationTest6()
        {
            var vector1 = new Vector2(3, 5);
            var vector2 = new Vector2(-1, 2);

            Assert.AreEqual(new Vector2(3, 5), vector1.Rotation(Direction.NORTH, vector2));
            Assert.AreEqual(new Vector2(-5, -1), vector1.Rotation(Direction.SOUTH, vector2));
            Assert.AreEqual(new Vector2(2, -2), vector1.Rotation(Direction.EAST, vector2));
            Assert.AreEqual(new Vector2(-4, 6), vector1.Rotation(Direction.WEST, vector2));
        }
    }
}
