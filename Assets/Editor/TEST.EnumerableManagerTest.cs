using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static partial class TEST
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
    }
}
