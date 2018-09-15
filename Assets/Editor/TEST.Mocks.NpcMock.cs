using System.Collections.Generic;
using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;

public static partial class TEST
{
    /// <summary>
    /// モックオブジェクト系のクラス
    /// </summary>
    partial class Mocks
    {
        /// <summary>
        /// <see cref="Npc"/>クラスのモック
        /// </summary>
        public class NpcMock : Npc
        {
            public static NpcMock GetMock() => new NpcMock(new NpcStationeryMock(new Parameters(
                nowHp: Default.NpcMock.MAX_HP,
                nowEnergy: Default.NpcMock.MAX_ENERGY,
                nowMental: Default.NpcMock.MAX_MENTAL,
                maxHp: Default.NpcMock.MAX_HP,
                maxEnergy: Default.NpcMock.MAX_ENERGY,
                maxMental: Default.NpcMock.MAX_MENTAL,
                physicalAttack: Default.NpcMock.PHYSICAL_ATTACK,
                physicalDefense: Default.NpcMock.PHYSICAL_DEFENSE,
                magicAttack: Default.NpcMock.MAGIC_ATTACK,
                magicDefense: Default.NpcMock.MAGIC_DEFENSE,
                accuracy: Default.NpcMock.ACCURACY,
                evasion: Default.NpcMock.EVASION,
                speed: Default.NpcMock.SPEED)));

            public static NpcMock GetSpeedMock(int speed) => new NpcMock(new NpcStationeryMock(new Parameters(
                nowHp: Default.NpcMock.MAX_HP,
                nowEnergy: Default.NpcMock.MAX_ENERGY,
                nowMental: Default.NpcMock.MAX_MENTAL,
                maxHp: Default.NpcMock.MAX_HP,
                maxEnergy: Default.NpcMock.MAX_ENERGY,
                maxMental: Default.NpcMock.MAX_MENTAL,
                physicalAttack: Default.NpcMock.PHYSICAL_ATTACK,
                physicalDefense: Default.NpcMock.PHYSICAL_DEFENSE,
                magicAttack: Default.NpcMock.MAGIC_ATTACK,
                magicDefense: Default.NpcMock.MAGIC_DEFENSE,
                accuracy: Default.NpcMock.ACCURACY,
                evasion: Default.NpcMock.EVASION,
                speed: speed)));

            public NpcMock(NpcStationery stationery, List<Adjective> adjectives = null, Friendship friendship = null, Parameters parametersAdjust = null, int? nowHp = null, int? nowEnergy = null, int? nowMental = null, int? nowInitiative = null, IEnumerable<Ailment> statusAilmentList = null) : base(stationery)
            {
            }

            /// <summary>
            /// 外部から参照されるスキルパラメータ
            /// </summary>
            public override Parameters parameters => stationery.parameters;
        }
    }
}
