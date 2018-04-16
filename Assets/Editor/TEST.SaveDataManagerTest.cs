﻿using Assets.Src.Domains.Models.Entity;
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
            var index1 = 0;
            var index2 = 3;
            var stateEntity1 = new GameStateEntity { upwardDirection = Direction.EAST };
            var stateEntity2 = new GameStateEntity { upwardDirection = Direction.NORTH };

            GameStates.CreateNewState(stateEntity1).Save(index1);
            GameStates.CreateNewState(stateEntity2).Save(index2);

            var result1 = GameStates.CreateNewState().Load(index1);
            var result2 = GameStates.CreateNewState().Load(index2);

            Assert.AreEqual(stateEntity1.upwardDirection, result1.upwardDirection);
            Assert.AreEqual(stateEntity2.upwardDirection, result2.upwardDirection);
        }
    }
}