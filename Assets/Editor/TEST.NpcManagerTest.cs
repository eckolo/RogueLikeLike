using Assets.Src.Domains;
using Assets.Src.Models.Npcs;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public static partial class TEST
{
    /// <summary>
    /// NPC系オブジェクト管理サービスのテスト
    /// </summary>
    public static class NpcManagerTest
    {
        const int DEF_MAX_HP = 10;
        const int DEF_MAX_ENERGY = 10;
        const int DEF_MAX_MENTAL = 10;
        const int DEF_PHYSICAL_ATTACK = 10;
        const int DEF_PHYSICAL_DEFENSE = 10;
        const int DEF_MAGIC_ATTACK = 10;
        const int DEF_MAGIC_DEFENSE = 10;
        const int DEF_ACCURACY = 10;
        const int DEF_EVASION = 10;
        const int DEF_SPEED = 10;
        /// <summary>
        /// Npcクラスのモック
        /// </summary>
        class NpcMock : Npc
        {
            public NpcMock(Parameters parameters)
            {
                _parameters = parameters;
            }
            public static NpcMock GetSpeedMock(int speed) => new NpcMock(new Parameters(
                maxHp: DEF_MAX_HP,
                maxEnergy: DEF_MAX_ENERGY,
                maxMental: DEF_MAX_MENTAL,
                physicalAttack: DEF_PHYSICAL_ATTACK,
                physicalDefense: DEF_PHYSICAL_DEFENSE,
                magicAttack: DEF_MAGIC_ATTACK,
                magicDefense: DEF_MAGIC_DEFENSE,
                accuracy: DEF_ACCURACY,
                evasion: DEF_EVASION,
                speed: speed));
            Parameters _parameters = null;

            public override Parameters parameters => _parameters;
        }
        [Test]
        public static void GetNextActNpcTest()
        {
            var npc1 = NpcMock.GetSpeedMock(11);
            var npc2 = NpcMock.GetSpeedMock(15);
            var npc3 = NpcMock.GetSpeedMock(18);
            var list = new List<Npc> { npc1, npc2, npc3 };
            Npc actor = null;

            actor = actor.CalcNextActNpc(list);
            Assert.AreEqual(actor, npc3);
            Assert.AreEqual(npc1.nowInitiative, 0);
            Assert.AreEqual(npc2.nowInitiative, 4);
            Assert.AreEqual(npc3.nowInitiative, 7);

            actor = actor.CalcNextActNpc(list);
            Assert.AreEqual(actor, npc2);
            Assert.AreEqual(npc1.nowInitiative, 4);
            Assert.AreEqual(npc2.nowInitiative, 12);
            Assert.AreEqual(npc3.nowInitiative, 0);

            actor = actor.CalcNextActNpc(list);
            Assert.AreEqual(actor, npc3);
            Assert.AreEqual(npc1.nowInitiative, 3);
            Assert.AreEqual(npc2.nowInitiative, 0);
            Assert.AreEqual(npc3.nowInitiative, 6);

            actor = actor.CalcNextActNpc(list);
            Assert.AreEqual(actor, npc2);
            Assert.AreEqual(npc1.nowInitiative, 8);
            Assert.AreEqual(npc2.nowInitiative, 9);
            Assert.AreEqual(npc3.nowInitiative, 0);

            actor = actor.CalcNextActNpc(list);
            Assert.AreEqual(actor, npc1);
            Assert.AreEqual(npc1.nowInitiative, 10);
            Assert.AreEqual(npc2.nowInitiative, 0);
            Assert.AreEqual(npc3.nowInitiative, 9);
        }
    }
}
