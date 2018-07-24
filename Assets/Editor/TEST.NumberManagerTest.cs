using Assets.Src.Domains.Service;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

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
        [Test]
        public static void CorrectTest()
        {
            var scalar1 = 3f;
            var scalar2 = 5f;

            Assert.AreEqual(NumberManager.Correct(scalar1, scalar2), 4f);
            Assert.AreEqual(NumberManager.Correct(scalar1, scalar2, 1), 3f);
            Assert.AreEqual(NumberManager.Correct(scalar1, scalar2, 0), 5f);
        }
        [Test]
        public static void ToIntTest()
        {
            Assert.AreEqual(NumberManager.ToInt(true), 1);
            Assert.AreEqual(NumberManager.ToInt(false), 0);
        }
        [Test]
        public static void ToSignTest1()
        {
            Assert.AreEqual(NumberManager.ToSign(true), 1);
            Assert.AreEqual(NumberManager.ToSign(false), -1);
        }
        [Test]
        public static void ToSignTest2()
        {
            Assert.AreEqual(NumberManager.ToSign(108), 1);
            Assert.AreEqual(NumberManager.ToSign(-62), -1);
            Assert.AreEqual(NumberManager.ToSign(0), 0);
        }
        [Test]
        public static void SelectRandomTest()
        {
            var list1 = new List<float> { 0.5f, 7.8f, 832 };
            var list2 = new List<int> { 1, 2 };

            for(int i = 0; i < 120; i++)
            {
                var result = NumberManager.SelectRandom(list1);
                Assert.IsTrue(result == 0.5f || result == 7.8f || result == 832);
            }
            for(int i = 0; i < 120; i++)
            {
                var result = NumberManager.SelectRandom(list1, list2);
                Assert.IsTrue(result == 0.5f || result == 7.8f || result == 832);
            }
        }
        [Test]
        public static void LogTest1()
        {
            var value1 = Mathf.Exp(11.3f) - 1;
            var value2 = -Mathf.Exp(26.43f) + 1;
            var value3 = 0f;

            Assert.AreEqual(value1.Log(), 11.3f);
            Assert.AreEqual(value2.Log(), -26.43f);
            Assert.AreEqual(value3.Log(), 0);
        }
        [Test]
        public static void LogTest2()
        {
            var value1 = Mathf.Pow(2.6f, 11.3f) - 1;
            var value2 = -Mathf.Pow(4.63f, 26.43f) + 1;
            var value3 = 0f;

            Assert.AreEqual(value1.Log(2.6f), 11.3f);
            Assert.AreEqual(value2.Log(4.63f), -26.43f);
            Assert.AreEqual(value3.Log(2.6f), 0);
        }
        [Test]
        public static void Copy()
        {
            var objects1 = new List<Mocks.MockClass>{
                new Mocks.MockClass
                {
                    text1 = "test1",
                    text2 = "test2",
                    number = 3
                },
                new Mocks.MockClass
                {
                    text1 = "test3",
                    text2 = "test4",
                    number = 5
                }
            };
            var objects2 = new List<Mocks.MockClass>{
                new Mocks.MockClass
                {
                    text1 = "test5",
                    text2 = "test6",
                    number = 4
                },
                new Mocks.MockClass
                {
                    text1 = "test7",
                    text2 = "test8",
                    number = 9
                }
            };
            var objects3 = new List<Mocks.MockClass> { };
            List<Mocks.MockClass> objects4 = null;

            Assert.AreEqual(objects1, objects1.Copy());
            Assert.AreNotSame(objects1, objects1.Copy());
            Assert.AreEqual(objects1[0], objects1.Copy()[0]);
            Assert.AreEqual(objects1[1], objects1.Copy()[1]);
            Assert.AreSame(objects1[0], objects1.Copy()[0]);
            Assert.AreSame(objects1[1], objects1.Copy()[1]);

            Assert.AreNotEqual(objects2[0], objects1.Copy()[0]);
            Assert.AreNotEqual(objects2[1], objects1.Copy()[1]);

            Assert.AreEqual(objects3, objects3.Copy());
            Assert.AreEqual(objects4, objects4.Copy());
        }
        [Test]
        public static void ToPercentage()
        {
            float? number1 = 1.31f;
            float? number2 = 0.013f;
            float? number3 = 5f;
            float? number4 = null;

            Assert.AreEqual(number1.ToPercentage(), "1.31");
            Assert.AreEqual(number2.ToPercentage(), "0.01");
            Assert.AreEqual(number3.ToPercentage(), "5.00");
            Assert.AreEqual(number4.ToPercentage(), "-");
        }
    }
}
