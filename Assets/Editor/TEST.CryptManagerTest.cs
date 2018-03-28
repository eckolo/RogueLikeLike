using Assets.Src.Domains;
using Assets.Src.Infrastructure;
using NUnit.Framework;
using UnityEngine;
public static partial class TEST
{
    /// <summary>
    /// 暗号化クラスのテストモジュール
    /// </summary>
    public static class CryptManagerTest
    {
        [Test]
        public static void EncodeCryptDecodeCryptTest()
        {
            var text = "text";

            var result1 = text.EncodeCrypt();
            var result2 = result1.DecodeCrypt();

            Assert.AreNotEqual(text, result1);
            Assert.AreEqual(text, result2);
        }
    }
}
