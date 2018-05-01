﻿using Assets.Src.Domains.Service;
using NUnit.Framework;
using System.Collections.Generic;
using Assets.Src.Domains.Models.Entity;

public static partial class TEST
{
    /// <summary>
    /// NPC系オブジェクト管理サービスのテスト
    /// </summary>
    public static partial class NpcManagerTest
    {
        [Test]
        public static void GetNextActNpcTest()
        {
            var npc1 = Mocks.NpcMock.GetSpeedMock(10);
            var npc2 = Mocks.NpcMock.GetSpeedMock(15);
            var npc3 = Mocks.NpcMock.GetSpeedMock(18);
            var list = new List<Npc> { npc1, npc2, npc3 };
            IGameStates states = GameStatesMock.GetNpcListMock(list);
            Npc actor = null;

            states = states.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc3);
            Assert.AreEqual(npc1.nowInitiative, 0);
            Assert.AreEqual(npc2.nowInitiative, 5);
            Assert.AreEqual(npc3.nowInitiative, 8);

            states = states.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc2);
            Assert.AreEqual(npc1.nowInitiative, 2);
            Assert.AreEqual(npc2.nowInitiative, 12);
            Assert.AreEqual(npc3.nowInitiative, 0);

            states = states.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc3);
            Assert.AreEqual(npc1.nowInitiative, 0);
            Assert.AreEqual(npc2.nowInitiative, 0);
            Assert.AreEqual(npc3.nowInitiative, 6);

            states = states.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc2);
            Assert.AreEqual(npc1.nowInitiative, 4);
            Assert.AreEqual(npc2.nowInitiative, 9);
            Assert.AreEqual(npc3.nowInitiative, 0);

            states = states.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc3);
            Assert.AreEqual(npc1.nowInitiative, 5);
            Assert.AreEqual(npc2.nowInitiative, 0);
            Assert.AreEqual(npc3.nowInitiative, 9);

            states = states.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc2);
            Assert.AreEqual(npc1.nowInitiative, 6);
            Assert.AreEqual(npc2.nowInitiative, 6);
            Assert.AreEqual(npc3.nowInitiative, 0);

            states = states.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc3);
            Assert.AreEqual(npc1.nowInitiative, 10);
            Assert.AreEqual(npc2.nowInitiative, 0);
            Assert.AreEqual(npc3.nowInitiative, 12);

            states = states.CalcInitiativeTurnEnd(actor);
            actor = list.CalcNextActNpc();
            Assert.AreEqual(actor, npc1);
            Assert.AreEqual(npc1.nowInitiative, 8);
            Assert.AreEqual(npc2.nowInitiative, 3);
            Assert.AreEqual(npc3.nowInitiative, 0);
        }
    }
}
