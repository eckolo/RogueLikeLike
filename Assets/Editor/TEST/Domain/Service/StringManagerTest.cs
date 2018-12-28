using Assets.Src.Domain.Service;
using NUnit.Framework;

namespace Assets.Editor.TEST.Domain.Service
{
    /// <summary>
    /// 文字列処理サービスのテスト
    /// </summary>
    public static class StringManagerTest
    {
        [Test]
        public static void ConvertSnakeToPascalTest()
        {
            var snakeCase1 = "test_text";
            var snakeCase2 = "TEST_TEXT";
            var pascalCase = "TestText";

            Assert.AreEqual(snakeCase1.ConvertSnakeToPascal(), pascalCase);
            Assert.AreEqual(snakeCase2.ConvertSnakeToPascal(), pascalCase);
        }
    }
}
