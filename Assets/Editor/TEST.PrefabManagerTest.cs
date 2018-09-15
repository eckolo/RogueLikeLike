using Assets.Src.Infrastructure.Service;
using NUnit.Framework;
using UnityEngine;

public static partial class TEST
{
    /// <summary>
    /// プレファブなどの実体化されたオブジェクト類の管理クラスのテストモジュール
    /// </summary>
    public static class PrefabManagerTest
    {
        /// <summary>
        /// ユニットテスト用MonoBehaviour
        /// </summary>
        public class TestMonoBehaviour : MonoBehaviour
        {

        }

        [Test]
        public static void SetObjectTest()
        {
            var name1 = "object1";
            var object1 = name1.SetObject<TestMonoBehaviour>();
            var object2 = GameObject.Find(name1).GetComponent<TestMonoBehaviour>();
            var object3 = PrefabManager.SetObject<TestMonoBehaviour>(null);

            Assert.IsTrue(object1 == object2);
            Assert.AreEqual(name1, object1.name);
            Assert.AreEqual(name1, object2.name);
            Assert.AreEqual(PrefabManager.ANONYMOUS_NAME, object3.name);
        }
        [Test]
        public static void SetObjectTest2()
        {
            var name1 = "TestMonoBehaviour";
            var object1 = PrefabManager.SetObject<TestMonoBehaviour>();
            var object2 = GameObject.Find(name1).GetComponent<TestMonoBehaviour>();

            Assert.IsTrue(object1 == object2);
            Assert.AreEqual(name1, object1.name);
            Assert.AreEqual(name1, object2.name);
        }
        [Test]
        public static void SetParentTest()
        {
            var object1 = new GameObject("object1", typeof(TestMonoBehaviour)).GetComponent<TestMonoBehaviour>();
            var object2 = new GameObject("object2", typeof(TestMonoBehaviour)).GetComponent<TestMonoBehaviour>();
            var object3 = object1.SetParent(object2);

            Assert.IsTrue(object1 == object3);
            Assert.IsTrue(object1.transform.parent == object2.transform);
            Assert.IsTrue(object3.transform.parent == object2.transform);
        }
    }
}
