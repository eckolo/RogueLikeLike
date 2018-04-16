using Assets.Src.Domains.Models.Entity;

public static partial class TEST
{
    public static partial class NpcManagerTest
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

            public NpcMock(Parameters parameters)
            {
                _parameters = parameters;
            }

            Parameters _parameters = null;
            public override Parameters parameters => _parameters;
        }
    }
}
