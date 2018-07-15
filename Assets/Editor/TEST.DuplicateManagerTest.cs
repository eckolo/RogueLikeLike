using Assets.Src.Domains.Service;
using NUnit.Framework;

public static partial class TEST
{
    /// <summary>
    /// <see cref="DuplicateManager"/>のテスト
    /// </summary>
    public static class DuplicateManagerTest
    {
        static Mocks.MockClass origin = new Mocks.MockClass
        {
            text1 = "text1",
            text2 = "text2",
            number = 3,
            innerClass = new Mocks.MockClass.InnerMockClass
            {
                text1 = "text1-1",
                text2 = "text1-2",
                number = 12
            }
        };

        [Test]
        public static void DuplicateTest()
        {
            var duplicated = origin.Duplicate();

            Assert.IsNotNull(duplicated);
            Assert.AreNotSame(origin, duplicated);
            Assert.AreEqual(origin.text1, duplicated.text1);
            Assert.AreEqual(origin.text2, duplicated.text2);
            Assert.AreEqual(origin.number, duplicated.number);

            Assert.IsNotNull(duplicated.innerClass);
            Assert.AreSame(origin.innerClass, duplicated.innerClass);
            Assert.AreEqual(origin.innerClass.text1, duplicated.innerClass.text1);
            Assert.AreEqual(origin.innerClass.text2, duplicated.innerClass.text2);
            Assert.AreEqual(origin.innerClass.number, duplicated.innerClass.number);
        }

        [Test]
        public static void DuplicateFullTest()
        {
            var duplicated = origin.DuplicateFull();

            Assert.IsNotNull(duplicated);
            Assert.AreNotSame(origin, duplicated);
            Assert.AreEqual(origin.text1, duplicated.text1);
            Assert.AreEqual(origin.text2, duplicated.text2);
            Assert.AreEqual(origin.number, duplicated.number);

            Assert.IsNotNull(duplicated.innerClass);
            Assert.AreNotSame(origin.innerClass, duplicated.innerClass);
            Assert.AreEqual(origin.innerClass.text1, duplicated.innerClass.text1);
            Assert.AreEqual(origin.innerClass.text2, duplicated.innerClass.text2);
            Assert.AreEqual(origin.innerClass.number, duplicated.innerClass.number);
        }
    }
}
