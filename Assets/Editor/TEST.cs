using NUnit.Framework;
using UnityEngine;
/// <summary>
/// ユニットテストモジュール
/// </summary>
public static partial class TEST
{
    /// <summary>
    /// ユニットテスト自体が正常に行われているか否かの確認
    /// 必ず成功するはずのテストを行う
    /// </summary>
    [Test]
    public static void BaseTest()
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
