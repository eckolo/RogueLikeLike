using UnityEngine;
using NUnit.Framework;

/// <summary>
/// ユニットテストモジュール
/// </summary>
public static partial class TEST
{
    /// <summary>
    /// ユニットテストモジュール自体のテストモジュール
    /// </summary>
    public static class Myself
    {
        /// <summary>
        /// ユニットテスト自体が正常に行われているか否かの確認
        /// 必ず成功するはずのテストを行う
        /// </summary>
        [Test]
        public static void TestBase()
        {
            //Arrange
            var gameObject = new GameObject();

            //Act
            //Try to rename the GameObject
            var newGameObjectName = "testBase";
            gameObject.name = newGameObjectName;

            //Assert
            //The object has a new name
            Assert.AreEqual(newGameObjectName, gameObject.name);
        }
    }
}
