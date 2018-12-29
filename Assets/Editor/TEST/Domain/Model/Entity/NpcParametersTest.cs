using Assets.Editor.TEST.Domain.Model.Mock;
using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;
using NUnit.Framework;

namespace Assets.Editor.TEST.Domain.Model.Entity
{
    /// <summary>
    /// <see cref="Npc.Parameters"/>のテスト
    /// </summary>
    public static class NpcParametersTest
    {
        static NpcStationery.Parameters parametersStationery = new NpcStationery.Parameters(
              maxHp: NpcParametersMock.MAX_HP,
              maxEnergy: NpcParametersMock.MAX_ENERGY,
              maxMental: NpcParametersMock.MAX_MENTAL,
              physicalAttack: NpcParametersMock.PHYSICAL_ATTACK,
              physicalDefense: NpcParametersMock.PHYSICAL_DEFENSE,
              magicAttack: NpcParametersMock.MAGIC_ATTACK,
              magicDefense: NpcParametersMock.MAGIC_DEFENSE,
              accuracy: NpcParametersMock.ACCURACY,
              evasion: NpcParametersMock.EVASION,
              speed: NpcParametersMock.SPEED);
        static Npc.Parameters parameters = new Npc.Parameters(
              nowHp: NpcParametersMock.NOW_HP,
              nowEnergy: NpcParametersMock.NOW_ENERGY,
              nowMental: NpcParametersMock.NOW_MENTAL,
              maxHp: NpcParametersMock.MAX_HP,
              maxEnergy: NpcParametersMock.MAX_ENERGY,
              maxMental: NpcParametersMock.MAX_MENTAL,
              physicalAttack: NpcParametersMock.PHYSICAL_ATTACK,
              physicalDefense: NpcParametersMock.PHYSICAL_DEFENSE,
              magicAttack: NpcParametersMock.MAGIC_ATTACK,
              magicDefense: NpcParametersMock.MAGIC_DEFENSE,
              accuracy: NpcParametersMock.ACCURACY,
              evasion: NpcParametersMock.EVASION,
              speed: NpcParametersMock.SPEED);

        [Test]
        public static void InnerProductTest()
        {
            var result = parametersStationery + parameters;

            result.innerProduct.Is(parameters.nowHp + parameters.nowEnergy + parameters.nowMental
                + parameters.maxHp + parametersStationery.maxHp
                + parameters.maxEnergy + parametersStationery.maxEnergy
                + parameters.maxMental + parametersStationery.maxMental
                + parameters.physicalAttack + parametersStationery.physicalAttack
                + parameters.physicalDefense + parametersStationery.physicalDefense
                + parameters.magicAttack + parametersStationery.magicAttack
                + parameters.magicDefense + parametersStationery.magicDefense
                + parameters.accuracy + parametersStationery.accuracy
                + parameters.evasion + parametersStationery.evasion
                + parameters.speed + parametersStationery.speed);
        }

        [Test]
        public static void AddTest1()
        {
            var result = parameters + parametersStationery;

            result.nowHp.Is(parameters.nowHp);
            result.nowEnergy.Is(parameters.nowEnergy);
            result.nowMental.Is(parameters.nowMental);
            result.maxHp.Is(parameters.maxHp + parametersStationery.maxHp);
            result.maxEnergy.Is(parameters.maxEnergy + parametersStationery.maxEnergy);
            result.maxMental.Is(parameters.maxMental + parametersStationery.maxMental);
            result.physicalAttack.Is(parameters.physicalAttack + parametersStationery.physicalAttack);
            result.physicalDefense.Is(parameters.physicalDefense + parametersStationery.physicalDefense);
            result.magicAttack.Is(parameters.magicAttack + parametersStationery.magicAttack);
            result.magicDefense.Is(parameters.magicDefense + parametersStationery.magicDefense);
            result.accuracy.Is(parameters.accuracy + parametersStationery.accuracy);
            result.evasion.Is(parameters.evasion + parametersStationery.evasion);
            result.speed.Is(parameters.speed + parametersStationery.speed);
        }

        [Test]
        public static void AddTest2()
        {
            var result = parametersStationery + parameters;

            result.nowHp.Is(parameters.nowHp);
            result.nowEnergy.Is(parameters.nowEnergy);
            result.nowMental.Is(parameters.nowMental);
            result.maxHp.Is(parameters.maxHp + parametersStationery.maxHp);
            result.maxEnergy.Is(parameters.maxEnergy + parametersStationery.maxEnergy);
            result.maxMental.Is(parameters.maxMental + parametersStationery.maxMental);
            result.physicalAttack.Is(parameters.physicalAttack + parametersStationery.physicalAttack);
            result.physicalDefense.Is(parameters.physicalDefense + parametersStationery.physicalDefense);
            result.magicAttack.Is(parameters.magicAttack + parametersStationery.magicAttack);
            result.magicDefense.Is(parameters.magicDefense + parametersStationery.magicDefense);
            result.accuracy.Is(parameters.accuracy + parametersStationery.accuracy);
            result.evasion.Is(parameters.evasion + parametersStationery.evasion);
            result.speed.Is(parameters.speed + parametersStationery.speed);
        }

        [Test]
        public static void MultiplyTest1()
        {
            var result = parameters * parametersStationery;

            result.nowHp.Is(0);
            result.nowEnergy.Is(0);
            result.nowMental.Is(0);
            result.maxHp.Is(parameters.maxHp * parametersStationery.maxHp);
            result.maxEnergy.Is(parameters.maxEnergy * parametersStationery.maxEnergy);
            result.maxMental.Is(parameters.maxMental * parametersStationery.maxMental);
            result.physicalAttack.Is(parameters.physicalAttack * parametersStationery.physicalAttack);
            result.physicalDefense.Is(parameters.physicalDefense * parametersStationery.physicalDefense);
            result.magicAttack.Is(parameters.magicAttack * parametersStationery.magicAttack);
            result.magicDefense.Is(parameters.magicDefense * parametersStationery.magicDefense);
            result.accuracy.Is(parameters.accuracy * parametersStationery.accuracy);
            result.evasion.Is(parameters.evasion * parametersStationery.evasion);
            result.speed.Is(parameters.speed * parametersStationery.speed);
        }

        [Test]
        public static void MultiplyTest2()
        {
            var result = parametersStationery * parameters;

            result.nowHp.Is(0);
            result.nowEnergy.Is(0);
            result.nowMental.Is(0);
            result.maxHp.Is(parameters.maxHp * parametersStationery.maxHp);
            result.maxEnergy.Is(parameters.maxEnergy * parametersStationery.maxEnergy);
            result.maxMental.Is(parameters.maxMental * parametersStationery.maxMental);
            result.physicalAttack.Is(parameters.physicalAttack * parametersStationery.physicalAttack);
            result.physicalDefense.Is(parameters.physicalDefense * parametersStationery.physicalDefense);
            result.magicAttack.Is(parameters.magicAttack * parametersStationery.magicAttack);
            result.magicDefense.Is(parameters.magicDefense * parametersStationery.magicDefense);
            result.accuracy.Is(parameters.accuracy * parametersStationery.accuracy);
            result.evasion.Is(parameters.evasion * parametersStationery.evasion);
            result.speed.Is(parameters.speed * parametersStationery.speed);
        }

        [Test]
        public static void IndexerTest1()
        {
            parametersStationery[ParameterType.NOW_HP].Is(NpcParametersMock.MAX_HP);
            parametersStationery[ParameterType.NOW_ENERGY].Is(NpcParametersMock.MAX_ENERGY);
            parametersStationery[ParameterType.NOW_MENTAL].Is(NpcParametersMock.MAX_MENTAL);
            parametersStationery[ParameterType.MAX_HP].Is(NpcParametersMock.MAX_HP);
            parametersStationery[ParameterType.MAX_ENERGY].Is(NpcParametersMock.MAX_ENERGY);
            parametersStationery[ParameterType.MAX_MENTAL].Is(NpcParametersMock.MAX_MENTAL);
            parametersStationery[ParameterType.PHYSICAL_ATTACK].Is(NpcParametersMock.PHYSICAL_ATTACK);
            parametersStationery[ParameterType.PHYSICAL_DEFENSE].Is(NpcParametersMock.PHYSICAL_DEFENSE);
            parametersStationery[ParameterType.MAGIC_ATTACK].Is(NpcParametersMock.MAGIC_ATTACK);
            parametersStationery[ParameterType.MAGIC_DEFENSE].Is(NpcParametersMock.MAGIC_DEFENSE);
            parametersStationery[ParameterType.ACCURACY].Is(NpcParametersMock.ACCURACY);
            parametersStationery[ParameterType.EVASION].Is(NpcParametersMock.EVASION);
            parametersStationery[ParameterType.SPEED].Is(NpcParametersMock.SPEED);
        }

        [Test]
        public static void IndexerTest2()
        {
            parameters[ParameterType.NOW_HP].Is(NpcParametersMock.NOW_HP);
            parameters[ParameterType.NOW_ENERGY].Is(NpcParametersMock.NOW_ENERGY);
            parameters[ParameterType.NOW_MENTAL].Is(NpcParametersMock.NOW_MENTAL);
            parameters[ParameterType.MAX_HP].Is(NpcParametersMock.MAX_HP);
            parameters[ParameterType.MAX_ENERGY].Is(NpcParametersMock.MAX_ENERGY);
            parameters[ParameterType.MAX_MENTAL].Is(NpcParametersMock.MAX_MENTAL);
            parameters[ParameterType.PHYSICAL_ATTACK].Is(NpcParametersMock.PHYSICAL_ATTACK);
            parameters[ParameterType.PHYSICAL_DEFENSE].Is(NpcParametersMock.PHYSICAL_DEFENSE);
            parameters[ParameterType.MAGIC_ATTACK].Is(NpcParametersMock.MAGIC_ATTACK);
            parameters[ParameterType.MAGIC_DEFENSE].Is(NpcParametersMock.MAGIC_DEFENSE);
            parameters[ParameterType.ACCURACY].Is(NpcParametersMock.ACCURACY);
            parameters[ParameterType.EVASION].Is(NpcParametersMock.EVASION);
            parameters[ParameterType.SPEED].Is(NpcParametersMock.SPEED);
        }
    }
}
