using Assets.Src.Domains.Service;
using NUnit.Framework;
public static partial class TEST
{
    /// <summary>
    /// <see cref="NumberManager"/>クラスのテスト
    /// </summary>
    public static class NumberManagerTest
    {
        [Test]
        public static void EuclideanTest()
        {
            var value1 = 2 * 2 * 3 * 11;
            var value2 = 2 * 2 * 5;
            var value3 = -1 * 3 * 5 * 7 * 11;
            var value4 = 1;
            var value5 = 0;

            Assert.AreEqual(value1, value1.Euclidean(value1));
            Assert.AreEqual(4, value1.Euclidean(value2));
            Assert.AreEqual(33, value1.Euclidean(value3));
            Assert.AreEqual(1, value1.Euclidean(value4));
            Assert.AreEqual(1, value1.Euclidean(value5));
            Assert.AreEqual(value2, value2.Euclidean(value2));
            Assert.AreEqual(5, value2.Euclidean(value3));
            Assert.AreEqual(1, value2.Euclidean(value4));
            Assert.AreEqual(1, value2.Euclidean(value5));
            Assert.AreEqual(value3, value3.Euclidean(value3));
            Assert.AreEqual(1, value3.Euclidean(value4));
            Assert.AreEqual(1, value3.Euclidean(value5));
            Assert.AreEqual(value4, value4.Euclidean(value4));
            Assert.AreEqual(1, value4.Euclidean(value5));
            Assert.AreEqual(1, value5.Euclidean(value5));
        }
    }
}
