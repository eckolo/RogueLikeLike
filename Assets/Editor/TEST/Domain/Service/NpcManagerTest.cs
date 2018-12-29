using Assets.Editor.TEST.Domain.Model.Mock;
using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Service;
using NUnit.Framework;
using System.Collections.Generic;

namespace Assets.Editor.TEST.Domain.Service
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
            actor.Is(npc3);
            npc1.nowInitiative.Is(0);
            npc2.nowInitiative.Is(5);
            npc3.nowInitiative.Is(8);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            actor.Is(npc2);
            npc1.nowInitiative.Is(2);
            npc2.nowInitiative.Is(12);
            npc3.nowInitiative.Is(0);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            actor.Is(npc3);
            npc1.nowInitiative.Is(0);
            npc2.nowInitiative.Is(0);
            npc3.nowInitiative.Is(6);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            actor.Is(npc2);
            npc1.nowInitiative.Is(4);
            npc2.nowInitiative.Is(9);
            npc3.nowInitiative.Is(0);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            actor.Is(npc3);
            npc1.nowInitiative.Is(5);
            npc2.nowInitiative.Is(0);
            npc3.nowInitiative.Is(9);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            actor.Is(npc2);
            npc1.nowInitiative.Is(6);
            npc2.nowInitiative.Is(6);
            npc3.nowInitiative.Is(0);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            actor.Is(npc3);
            npc1.nowInitiative.Is(10);
            npc2.nowInitiative.Is(0);
            npc3.nowInitiative.Is(12);

            state = state.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            actor.Is(npc1);
            npc1.nowInitiative.Is(8);
            npc2.nowInitiative.Is(3);
            npc3.nowInitiative.Is(0);

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
