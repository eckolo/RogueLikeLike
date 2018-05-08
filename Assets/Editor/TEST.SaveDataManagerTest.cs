using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using Assets.Src.Infrastructure;
using NUnit.Framework;
using UnityEngine;

public static partial class TEST
{
    /// <summary>
    /// セーブデータを管理するクラスのテストモジュール
    /// </summary>
    public static class SaveDataManagerTest
    {
        [Test]
        public static void SaveLoadTest()
        {
            System.IO.File.Delete($@"{Application.dataPath}/{Application.productName}.save");

            var seed = 0;
            var index1 = 0;
            var index2 = 3;
            var state1 = new GameState(seed) { upwardDirection = Direction.EAST };
            var state2 = new GameState(seed) { upwardDirection = Direction.NORTH };

            GameFoundation.CreateNewState(state1).Save(index1);
            GameFoundation.CreateNewState(state2).Save(index2);

            var result1 = GameFoundation.CreateNewState(seed).Load(index1);
            var result2 = GameFoundation.CreateNewState(seed).Load(index2);

            Assert.AreEqual(state1.upwardDirection, result1.upwardDirection);
            Assert.AreEqual(state2.upwardDirection, result2.upwardDirection);
        }
    }
}
