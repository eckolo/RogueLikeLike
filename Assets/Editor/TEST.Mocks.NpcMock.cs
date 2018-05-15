using Assets.Src.Domains.Models.Entity;

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
            public static NpcMock GetMock() => new NpcMock(new Parameters(
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
                speed: Default.NpcMock.SPEED));

            public static NpcMock GetSpeedMock(int speed) => new NpcMock(new Parameters(
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
                speed: speed));

            NpcMock(Parameters parameters)
            {
                _parameters = parameters;
            }

            Parameters _parameters = null;
            public override Parameters parameters => _parameters;
        }
    }
}
