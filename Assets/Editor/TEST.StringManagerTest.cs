using Assets.Src.Domains;
using NUnit.Framework;
using UnityEngine;
public static partial class TEST
{
    /// <summary>
    /// 文字列処理サービスのテスト
    /// </summary>
    public static class StringManagerTest
    {
        [Test]
        public static void ConvertSnakeToUpperCamel()
        {
            var snakeCase1 = "test_text";
            var snakeCase2 = "TEST_TEXT";
            var pascalCase = "TestText";

            Assert.AreEqual(snakeCase1.ConvertSnakeToPascal(), pascalCase);
            Assert.AreEqual(snakeCase2.ConvertSnakeToPascal(), pascalCase);
        }
    }
}
