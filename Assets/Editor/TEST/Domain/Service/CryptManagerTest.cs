using NUnit.Framework;
namespace TEST.Domain.Service
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