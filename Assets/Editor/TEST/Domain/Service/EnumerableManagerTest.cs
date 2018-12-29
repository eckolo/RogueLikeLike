using Assets.Src.Domain.Model.Abstract;
using Assets.Src.Domain.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Editor.TEST.Domain.Service
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
                this.key = key;
                this.value = value;
            }

            public string key { get; } = "";
            public float value { get; } = 0f;
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
            result.Count().Is(2);

            var resultFirst = result.Single(elem => elem.x > 0);
            var resultSecond = result.Single(elem => elem.x < 0);
            resultFirst.x.Is(6);
            resultFirst.y.Is(-8);
            resultSecond.x.Is(-6);
            resultSecond.y.Is(8);
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
            result.Count().Is(2);

            var resultFirst = result.Single(elem => elem.x > 0);
            var resultSecond = result.Single(elem => elem.x < 0);
            resultFirst.x.Is(3);
            resultFirst.y.Is(-4);
            resultSecond.x.Is(-3);
            resultSecond.y.Is(4);
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
            result1[key1].Is(value1);
            result1[key2].Is(value2);
            result1[key3].Is(value3);

            Assert.Throws<ArgumentException>(() => list2.ToDictionary());
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

            dictionary.GetOrDefault(key1).Is(value1);
            dictionary.GetOrDefault(key2).Is(value2);
            dictionary.GetOrDefault(key3).Is(value3);
            dictionary.GetOrDefault(key4).Is(default(float));
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

            dictionary.GetOrDefault(key1, valueDefault).Is(value1);
            dictionary.GetOrDefault(key2, valueDefault).Is(value2);
            dictionary.GetOrDefault(key3, valueDefault).Is(value3);
            dictionary.GetOrDefault(key4, valueDefault).Is(valueDefault);
        }
        [Test]
        public static void UpdateOrInsertTest_1要素_正常系()
        {
            var key1 = "test1";
            var key2 = "test2";
            var key3 = "test3";
            var key4 = "test4";
            var value1 = 0.3f;
            var value2 = 1.2f;
            var value3 = 5;
            var value4 = 7.4f;
            var dictionary = new Dictionary<string, float>
            {
                { key1, value1},
                { key2, value2},
                { key3, value3},
            };

            {
                var result = dictionary.UpdateOrInsert(key2, value4);
                result.Count.Is(3);
                result.ContainsKey(key1).IsTrue();
                result[key1].Is(value1);
                result.ContainsKey(key2).IsTrue();
                result[key2].Is(value4);
                result.ContainsKey(key3).IsTrue();
                result[key3].Is(value3);
            }
            {
                var result = dictionary.UpdateOrInsert(key4, value4);
                result.Count.Is(4);
                result.ContainsKey(key1).IsTrue();
                result[key1].Is(value1);
                result.ContainsKey(key2).IsTrue();
                result[key2].Is(value2);
                result.ContainsKey(key3).IsTrue();
                result[key3].Is(value3);
                result.ContainsKey(key4).IsTrue();
                result[key4].Is(value4);
            }
        }
        [Test]
        public static void UpdateOrInsertTest_1要素_Nullの値()
        {
            var key1 = "test1";
            var key2 = "test2";
            var key3 = "test3";
            var key4 = "test4";
            var value1 = 0.3f;
            var value2 = 1.2f;
            var value3 = 5;
            float? value4 = null;
            var dictionary = new Dictionary<string, float?>
            {
                { key1, value1},
                { key2, value2},
                { key3, value3},
            };

            {
                var result = dictionary.UpdateOrInsert(key2, value4);
                result.Count.Is(3);
                result.ContainsKey(key1).IsTrue();
                result[key1].Is(value1);
                result.ContainsKey(key2).IsTrue();
                result[key2].Is(value4);
                result.ContainsKey(key3).IsTrue();
                result[key3].Is(value3);
            }
            {
                var result = dictionary.UpdateOrInsert(key4, value4);
                result.Count.Is(4);
                result.ContainsKey(key1).IsTrue();
                result[key1].Is(value1);
                result.ContainsKey(key2).IsTrue();
                result[key2].Is(value2);
                result.ContainsKey(key3).IsTrue();
                result[key3].Is(value3);
                result.ContainsKey(key4).IsTrue();
                result[key4].Is(value4);
            }
        }
        [Test]
        public static void UpdateOrInsertTest_1要素_Nullのキー()
        {
            var key1 = "test1";
            var key2 = "test2";
            var key3 = "test3";
            string key4 = null;
            var value1 = 0.3f;
            var value2 = 1.2f;
            var value3 = 5;
            var value4 = 7.4f;
            var dictionary = new Dictionary<string, float?>
            {
                { key1, value1},
                { key2, value2},
                { key3, value3},
            };

            Assert.Throws<ArgumentNullException>(() => dictionary.UpdateOrInsert(key4, value4));
        }
        [Test]
        public static void UpdateOrInsertTest_複数要素_正常系()
        {
            var key1 = "test1";
            var key2 = "test2";
            var key3 = "test3";
            var key4 = "test4";
            var value1 = 0.3f;
            var value2 = 1.2f;
            var value3 = 5;
            var value4 = 7.4f;
            var value5 = -72.65f;
            var dictionary = new Dictionary<string, float>
            {
                { key1, value1},
                { key2, value2},
                { key3, value3},
            };
            var update = new Dictionary<string, float>
            {
                { key4, value4},
                { key1, value5}
            };

            var result = dictionary.UpdateOrInsert(update);
            result.Count.Is(4);
            result.ContainsKey(key1).IsTrue();
            result[key1].Is(value5);
            result.ContainsKey(key2).IsTrue();
            result[key2].Is(value2);
            result.ContainsKey(key3).IsTrue();
            result[key3].Is(value3);
            result.ContainsKey(key4).IsTrue();
            result[key4].Is(value4);
        }
        [Test]
        public static void UpdateOrInsertTest_複数要素_Nullの値()
        {
            var key1 = "test1";
            var key2 = "test2";
            var key3 = "test3";
            var key4 = "test4";
            var value1 = 0.3f;
            var value2 = 1.2f;
            var value3 = 5;
            var dictionary = new Dictionary<string, float?>
            {
                { key1, value1},
                { key2, value2},
                { key3, value3},
            };
            var update = new Dictionary<string, float?>
            {
                { key4, null},
                { key1, null}
            };

            var result = dictionary.UpdateOrInsert(update);
            result.Count.Is(4);
            result.ContainsKey(key1).IsTrue();
            result[key1].Is(null);
            result.ContainsKey(key2).IsTrue();
            result[key2].Is(value2);
            result.ContainsKey(key3).IsTrue();
            result[key3].Is(value3);
            result.ContainsKey(key4).IsTrue();
            result[key4].Is(null);
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

            list.ContainsIndex(-1).IsFalse();
            list.ContainsIndex(0).IsTrue();
            list.ContainsIndex(3).IsTrue();
            list.ContainsIndex(4).IsFalse();
        }
        [Test]
        public static void PickTest_正常系()
        {
            var vector1 = new Vector2(1, 2);
            var vector2 = new Vector2(2, -8);
            var vector3 = new Vector2(3, 8);
            var vector4 = new Vector2(4, -1);
            var list = new List<Vector2> { vector1, vector2, vector3, vector4 };
            var rate = new List<int> { 10, 20, 30, 40 };
            var norm1 = 0.DividedBy(100);
            var norm2 = 9.DividedBy(100);
            var norm3 = 10.DividedBy(100);
            var norm4 = 29.DividedBy(100);
            var norm5 = 30.DividedBy(100);
            var norm6 = 59.DividedBy(100);
            var norm7 = 60.DividedBy(100);
            var norm8 = 99.DividedBy(100);

            list.Pick(norm1, rate).Is(vector1);
            list.Pick(norm2, rate).Is(vector1);
            list.Pick(norm3, rate).Is(vector2);
            list.Pick(norm4, rate).Is(vector2);
            list.Pick(norm5, rate).Is(vector3);
            list.Pick(norm6, rate).Is(vector3);
            list.Pick(norm7, rate).Is(vector4);
            list.Pick(norm8, rate).Is(vector4);
        }
        [Test]
        public static void PickTest_基準値が閾値外()
        {
            var vector1 = new Vector2(1, 2);
            var vector2 = new Vector2(2, -8);
            var vector3 = new Vector2(3, 8);
            var vector4 = new Vector2(4, -1);
            var list = new List<Vector2> { vector1, vector2, vector3, vector4 };
            var rate = new List<int> { 10, 20, 30, 40 };
            var norm1 = -1.DividedBy(100);
            var norm2 = 100.DividedBy(100);

            list.Pick(norm1, rate).Is(default);
            list.Pick(norm2, rate).Is(default);
        }
        [Test]
        public static void PickTest_確率分布が負の値()
        {
            var vector1 = new Vector2(1, 2);
            var vector2 = new Vector2(2, -8);
            var vector3 = new Vector2(3, 8);
            var vector4 = new Vector2(4, -1);
            var list = new List<Vector2> { vector1, vector2, vector3, vector4 };
            var rate = new List<int> { 10, -20, 30, 40 };
            var norm1 = 0.DividedBy(80);
            var norm2 = 9.DividedBy(80);
            var norm3 = 10.DividedBy(80);
            var norm4 = 39.DividedBy(80);
            var norm5 = 40.DividedBy(80);
            var norm6 = 79.DividedBy(80);

            list.Pick(norm1, rate).Is(vector1);
            list.Pick(norm2, rate).Is(vector1);
            list.Pick(norm3, rate).Is(vector3);
            list.Pick(norm4, rate).Is(vector3);
            list.Pick(norm5, rate).Is(vector4);
            list.Pick(norm6, rate).Is(vector4);
        }
        [Test]
        public static void PickTest_基準値が閾値外かつ確率分布が負の値()
        {
            var vector1 = new Vector2(1, 2);
            var vector2 = new Vector2(2, -8);
            var vector3 = new Vector2(3, 8);
            var vector4 = new Vector2(4, -1);
            var list = new List<Vector2> { vector1, vector2, vector3, vector4 };
            var rate = new List<int> { 10, -20, 30, 40 };
            var norm1 = -1.DividedBy(80);
            var norm2 = 80.DividedBy(80);

            list.Pick(norm1, rate).Is(default);
            list.Pick(norm2, rate).Is(default);
        }
    }
}
