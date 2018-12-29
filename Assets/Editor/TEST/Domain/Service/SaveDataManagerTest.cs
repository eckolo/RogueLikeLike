using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Service;
using Assets.Src.Infrastructure.Model.Entity;
using NUnit.Framework;
using UnityEngine;

namespace Assets.Editor.TEST.Domain.Service
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
            var state3 = new GameState(seed) { upwardDirection = Direction.WEST };
            var fileManager = GameFoundation.CreateNewState(seed).methods.fileManager;

            state1.Save(index1, fileManager);
            state2.Save(index2, fileManager);

            var result1 = state3.Load(index1, fileManager);
            var result2 = state3.Load(index2, fileManager);

            result1.upwardDirection.Is(state1.upwardDirection);
            result2.upwardDirection.Is(state2.upwardDirection);
        }
    }
}
