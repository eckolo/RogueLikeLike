using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;
using System.Collections.Generic;

namespace TEST.Domain.Model.Mock
{
    /// <summary>
    /// <summary>
    /// <see cref="Npc"/>クラスのモック
    /// </summary>
    public class NpcMock : Npc
    {
        public static NpcMock GetMock() => new NpcMock(new NpcStationeryMock(new Parameters(
            nowHp: NpcParametersMock.MAX_HP,
            nowEnergy: NpcParametersMock.MAX_ENERGY,
            nowMental: NpcParametersMock.MAX_MENTAL,
            maxHp: NpcParametersMock.MAX_HP,
            maxEnergy: NpcParametersMock.MAX_ENERGY,
            maxMental: NpcParametersMock.MAX_MENTAL,
            physicalAttack: NpcParametersMock.PHYSICAL_ATTACK,
            physicalDefense: NpcParametersMock.PHYSICAL_DEFENSE,
            magicAttack: NpcParametersMock.MAGIC_ATTACK,
            magicDefense: NpcParametersMock.MAGIC_DEFENSE,
            accuracy: NpcParametersMock.ACCURACY,
            evasion: NpcParametersMock.EVASION,
            speed: NpcParametersMock.SPEED)));

        public static NpcMock GetSpeedMock(int speed) => new NpcMock(new NpcStationeryMock(new Parameters(
            nowHp: NpcParametersMock.MAX_HP,
            nowEnergy: NpcParametersMock.MAX_ENERGY,
            nowMental: NpcParametersMock.MAX_MENTAL,
            maxHp: NpcParametersMock.MAX_HP,
            maxEnergy: NpcParametersMock.MAX_ENERGY,
            maxMental: NpcParametersMock.MAX_MENTAL,
            physicalAttack: NpcParametersMock.PHYSICAL_ATTACK,
            physicalDefense: NpcParametersMock.PHYSICAL_DEFENSE,
            magicAttack: NpcParametersMock.MAGIC_ATTACK,
            magicDefense: NpcParametersMock.MAGIC_DEFENSE,
            accuracy: NpcParametersMock.ACCURACY,
            evasion: NpcParametersMock.EVASION,
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
