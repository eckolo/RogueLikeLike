using Assets.Src.Domain.Model.Abstract;
using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TEST.Domain.Service
{
    /// <summary>
    /// <see cref="EnumerableManager">クラスのテスト
    /// </summary>
    public static class EnumerableManagerTest
    {
        /// <summary>
        /// <see cref="ToDictionaryTest"/>用クラス
        /// </summary>
        class KeyValueLikeTest : IKeyValueLike<string, float>
        {
            public KeyValueLikeTest(string key, float value)
            {
                _key = key;
                _value = value;
            }

            string _key = "";
            public string key => _key;
            float _value = 0f;
            public float value => _value;
        }

        [Test]
        public static void MaxKeysTest()
        {
            var list = new List<Vector2> {
                new Vector2(2, 2),
                new Vector2(6, -8),
                new Vector2(-6, 8),
                new Vector2(0, -1)
            };

            var result = list.MaxKeys(elem => elem.magnitude);
            Assert.AreEqual(result.Count(), 2);

            var resultFirst = result.Single(elem => elem.x > 0);
            var resultSecond = result.Single(elem => elem.x < 0);
            Assert.AreEqual(resultFirst.x, 6);
            Assert.AreEqual(resultFirst.y, -8);
            Assert.AreEqual(resultSecond.x, -6);
            Assert.AreEqual(resultSecond.y, 8);
        }
        [Test]
        public static void MinKeysTest()
        {
            var list = new List<Vector2> {
                new Vector2(6, 6),
                new Vector2(3, -4),
                new Vector2(-3, 4),
                new Vector2(0, -7)
            };

            var result = list.MinKeys(elem => elem.magnitude);
            Assert.AreEqual(result.Count(), 2);

            var resultFirst = result.Single(elem => elem.x > 0);
            var resultSecond = result.Single(elem => elem.x < 0);
            Assert.AreEqual(resultFirst.x, 3);
            Assert.AreEqual(resultFirst.y, -4);
            Assert.AreEqual(resultSecond.x, -3);
            Assert.AreEqual(resultSecond.y, 4);
        }
        [Test]
        public static void ToDictionaryTest()
        {
            var key1 = "test1";
            var key2 = "test2";
            var key3 = "test3";
            var value1 = 0.3f;
            var value2 = 1.2f;
            var value3 = 5;
            var list1 = new List<KeyValueLikeTest> {
                new KeyValueLikeTest(key1, value1),
                new KeyValueLikeTest(key2, value2),
                new KeyValueLikeTest(key3, value3)
            };
            var list2 = new List<KeyValueLikeTest> {
                new KeyValueLikeTest(key1, value1),
                new KeyValueLikeTest(key1, value2),
            };

            var result1 = list1.ToDictionary();
            Assert.AreEqual(result1[key1], value1);
            Assert.AreEqual(result1[key2], value2);
            Assert.AreEqual(result1[key3], value3);

            try
            {
                list2.ToDictionary();
                Assert.Fail();
            }
            catch(Exception error)
            {
                Assert.Pass(error.ToString());
            }
        }
        [Test]
        public static void GetOrDefaultTest()
        {
            var key1 = "test1";
            var key2 = "test2";
            var key3 = "test3";
            var key4 = "test4";
            var value1 = 0.3f;
            var value2 = 1.2f;
            var value3 = 5;
            var dictionary = new Dictionary<string, float>
            {
                { key1, value1},
                { key2, value2},
                { key3, value3},
            };

            Assert.AreEqual(dictionary.GetOrDefault(key1), value1);
            Assert.AreEqual(dictionary.GetOrDefault(key2), value2);
            Assert.AreEqual(dictionary.GetOrDefault(key3), value3);
            Assert.AreEqual(dictionary.GetOrDefault(key4), default(float));
        }
        [Test]
        public static void GetOrDefaultTest2()
        {
            var key1 = "test1";
            var key2 = "test2";
            var key3 = "test3";
            var key4 = "test4";
            var value1 = 0.3f;
            var value2 = 1.2f;
            var value3 = 5;
            var valueDefault = 7.4f;
            var dictionary = new Dictionary<string, float>
            {
                { key1, value1},
                { key2, value2},
                { key3, value3},
            };

            Assert.AreEqual(dictionary.GetOrDefault(key1, valueDefault), value1);
            Assert.AreEqual(dictionary.GetOrDefault(key2, valueDefault), value2);
            Assert.AreEqual(dictionary.GetOrDefault(key3, valueDefault), value3);
            Assert.AreEqual(dictionary.GetOrDefault(key4, valueDefault), valueDefault);
        }
        [Test]
        public static void ContainsIndexTest()
        {
            var list = new List<Vector2> {
                new Vector2(2, 2),
                new Vector2(6, -8),
                new Vector2(-6, 8),
                new Vector2(0, -1)
            };

            Assert.IsFalse(list.ContainsIndex(-1));
            Assert.IsTrue(list.ContainsIndex(0));
            Assert.IsTrue(list.ContainsIndex(3));
            Assert.IsFalse(list.ContainsIndex(4));
        }
        [Test]
        public static void PickTest()
        {
            var vector1 = new Vector2(2, 2);
            var vector2 = new Vector2(6, -8);
            var vector3 = new Vector2(-6, 8);
            var vector4 = new Vector2(0, -1);
            var list = new List<Vector2> { vector1, vector2, vector3, vector4 };
            var rate = new List<int> { 10, 20, 30, 40 };
            var norm0 = -1.DividedBy(100);
            var norm1 = 0.DividedBy(100);
            var norm2 = 9.DividedBy(100);
            var norm3 = 10.DividedBy(100);
            var norm4 = 29.DividedBy(100);
            var norm5 = 30.DividedBy(100);
            var norm6 = 59.DividedBy(100);
            var norm7 = 60.DividedBy(100);
            var norm8 = 99.DividedBy(100);
            var norm9 = 100.DividedBy(100);

            Assert.AreEqual(default(Vector2), list.Pick(norm0, rate));
            Assert.AreEqual(vector1, list.Pick(norm1, rate));
            Assert.AreEqual(vector1, list.Pick(norm2, rate));
            Assert.AreEqual(vector2, list.Pick(norm3, rate));
            Assert.AreEqual(vector2, list.Pick(norm4, rate));
            Assert.AreEqual(vector3, list.Pick(norm5, rate));
            Assert.AreEqual(vector3, list.Pick(norm6, rate));
            Assert.AreEqual(vector4, list.Pick(norm7, rate));
            Assert.AreEqual(vector4, list.Pick(norm8, rate));
            Assert.AreEqual(default(Vector2), list.Pick(norm9, rate));
        }
    }
}
