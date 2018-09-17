using Assets.Src.Domain.Service;
using NUnit.Framework;
using System.Collections.Generic;
using Assets.Src.Domain.Model.Entity;
using TEST.Domain.Model.Mock;

namespace TEST.Domain.Service
{
    /// <summary>
    /// NPC系オブジェクト管理サービスのテスト
    /// </summary>
    public static partial class NpcManagerTest
    {
        [Test]
        public static void GetNextActNpcTest()
        {
            var npc1 = NpcMock.GetSpeedMock(10);
            var npc2 = NpcMock.GetSpeedMock(15);
            var npc3 = NpcMock.GetSpeedMock(18);
            var list = new List<Npc> { npc1, npc2, npc3 };
            GameState state = GameStateMock.GetNpcListMock(list);
            Npc actor = null;

            #region Repetitive processing simulation every turn

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc3);
            Assert.AreEqual(npc1.nowInitiative, 0);
            Assert.AreEqual(npc2.nowInitiative, 5);
            Assert.AreEqual(npc3.nowInitiative, 8);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc2);
            Assert.AreEqual(npc1.nowInitiative, 2);
            Assert.AreEqual(npc2.nowInitiative, 12);
            Assert.AreEqual(npc3.nowInitiative, 0);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc3);
            Assert.AreEqual(npc1.nowInitiative, 0);
            Assert.AreEqual(npc2.nowInitiative, 0);
            Assert.AreEqual(npc3.nowInitiative, 6);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc2);
            Assert.AreEqual(npc1.nowInitiative, 4);
            Assert.AreEqual(npc2.nowInitiative, 9);
            Assert.AreEqual(npc3.nowInitiative, 0);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc3);
            Assert.AreEqual(npc1.nowInitiative, 5);
            Assert.AreEqual(npc2.nowInitiative, 0);
            Assert.AreEqual(npc3.nowInitiative, 9);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc2);
            Assert.AreEqual(npc1.nowInitiative, 6);
            Assert.AreEqual(npc2.nowInitiative, 6);
            Assert.AreEqual(npc3.nowInitiative, 0);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc3);
            Assert.AreEqual(npc1.nowInitiative, 10);
            Assert.AreEqual(npc2.nowInitiative, 0);
            Assert.AreEqual(npc3.nowInitiative, 12);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc1);
            Assert.AreEqual(npc1.nowInitiative, 8);
            Assert.AreEqual(npc2.nowInitiative, 3);
            Assert.AreEqual(npc3.nowInitiative, 0);

            #endregion
        }

        [Test]
        public static void ToParametersTest()
        {
            //TODO テスト書く
            Assert.Inconclusive();
        }

        [Test]
        public static void DetermineActionTest()
        {
            //TODO テスト書く
            Assert.Inconclusive();
        }

        [Test]
        public static void CalcStrongTest()
        {
            //TODO テスト書く
            Assert.Inconclusive();
        }

        [Test]
        public static void CalcLivelyTest()
        {
            //TODO テスト書く
            Assert.Inconclusive();
        }

        [Test]
        public static void CorrectMovingTest()
        {
            //TODO テスト書く
            Assert.Inconclusive();
        }
    }
}
