using NUnit.Framework;
namespace Assets.Editor.TEST.Domain.Service
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

            result1.IsNot(text);
            result2.Is(text);
        }
    }
}
