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

            snakeCase1.ConvertSnakeToPascal().Is(pascalCase);
            snakeCase2.ConvertSnakeToPascal().Is(pascalCase);
        }
    }
}
